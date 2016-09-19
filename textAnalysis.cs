using System;
using System.IO;

public class textAnalysis
{
    static void Main(string[] args)
    {

        // Displays text to aid user. Tells user what is needed to progress.
        Console.Write("Would You Like To: \n1-Enter Text Via Keyboard \n2-Read In Text From File");
        Console.Write("\nPlease Enter Your Selection: ");

        // Applies the user selection to a variable to enable either option.
        int initSelection;
        // Converts the user input data to int data type.
        initSelection = Convert.ToInt32(Console.ReadLine());

        String userTextTemp = "";
        String userTextFinal = "";

        if (initSelection == 1) // Option 1
        {
            // Creates variable to detect the end of the entry, reads last character of the string to detect a *.
            bool asterixFound = userTextTemp.EndsWith("*");

            // Loops to enable multiple sentence entry, loop performs check on asterixFound. Repeats until asterixFound is true.
            do
            {
                // Provides instructions for the user. 
                Console.Write("\nPlease Enter Your (next) Sentence(s) \n(Note: Remember to end your sentences with a full stop!)\n(Note: Please end your final sentence with *)\n");
                // Reads the user input and stores it in a temporary variable, then adds this sentence to the final group of text. 
                userTextTemp = Console.ReadLine();
                userTextFinal = userTextFinal + userTextTemp;
                // Performs check to see if the last sentence input ends with an asterix.
                asterixFound = userTextTemp.EndsWith("*");
            }
            // Loop continues until asterixFound check returns true.
            while (asterixFound != true);

            // Calls method to perform the analysis on the final inputted text. 
            performAnalysis(userTextFinal);

            // Confirms to the user that the text has been input correctly and displays them a copy.
            Console.Write("\n\nThank You for inputting your data!");
            Console.Write("\nYour Sentences are displayed below: \n{0}", userTextFinal);
            
        }
        else if (initSelection == 2) // Option 2
        {
            // Asks user to input directory of file containing their text. 
            Console.Write("\nPlease Enter the full Directory of your file (including file extensions): ");
            // Stores inputted text into fileDir variable.
            String fileDir = Console.ReadLine();
            
            // Stores the file extension from fileDir in the variable extension.
            String extension = Path.GetExtension(fileDir);

            // Performs check on file extension, if the file is not a text file then an error message is displayed to the user and the programme is killed. 
            if (extension != ".txt")
            {
                Console.Write("\nPlease restart and enter the correct directory listing. (Must include a '.txt' file)");
            }
            else
            {

                // Reads all the text in the file (file at the file directory specified) and stores that text in userTextFinal string.
                userTextFinal = File.ReadAllText(fileDir);

                // Confirms to the user that the text has been input correctly and displays them a copy.
                Console.Write("\n\nThank you your file has been input.");
                Console.Write("\nYour Sentences are displayed below: \n{0}", userTextFinal);
            }

            // Calls method to perform the analysis on the final inputted text. 
            performAnalysis(userTextFinal);
            longWords(userTextFinal);
            Console.Write("\nA file of long words has been created in the root direcotry.");
        }
        else
        {
            // If an invalid number or text has been input at the start, then a message is displayed to the user explaining the error. 
            Console.Write("\nInvalid Number. Please Restart And Enter A Valid Number!");
        }

    }

    // Method to count number of sentences in text.
    // The final inputted text is passed into the method.
    public static int countSentences(String userTextFinal)
    {
        // Declare variable to count number of sentences.
        int numberSentences = 0;
        // Loop progresses through final group of text (one character at a time).
        foreach (char fullStop in userTextFinal)
        {
            // Each time a declared character is found the count is increased by one.
            if (fullStop == '.' || fullStop == '!' || fullStop == '?')
            {
                numberSentences = numberSentences + 1;
            }
            
        }
        // Method returns the final count. 
        return numberSentences;
    }

    // Method to count number of vowels in text.
    // The final inputted text is passed into the method.
    public static int countVowels(String userTextFinal)
    {
        // Declare variable to count number of vowels.
        int numberVowels = 0;
        // Loop progresses through final group of text (one character at a time).
        foreach (char vowel in userTextFinal)
        {
            // Each time a declared character is found the count is increased by one.
            if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            {
                numberVowels = numberVowels + 1;
            }

        }
        // Method returns the final count.
        return numberVowels;
    }

    // Method to count number of consonants in text.
    // The final inputted text is passed into the method.
    public static int countConsonants(String userTextFinal)
    {
        // Declare variable to count number of consonants.
        int numberConsonants = 0;
        // Loop progresses through final group of text (one character at a time).
        foreach (char consonant in userTextFinal)
        {
            // Each time a declared character is found the count is increased by one.
            if (consonant == 'b' || consonant == 'c' || consonant == 'd' || consonant == 'f' || consonant == 'g' || consonant == 'h' || consonant == 'j' || consonant == 'k' || consonant == 'l' || consonant == 'm' || consonant == 'n' || consonant == 'p' || consonant == 'q' || consonant == 'r' || consonant == 's' || consonant == 't' || consonant == 'v' || consonant == 'w' || consonant == 'x' || consonant == 'y' || consonant == 'z')
            {
                numberConsonants = numberConsonants + 1;
            }

        }
        // Method returns the final count.
        return numberConsonants;
    }

    // Method to count number of upper case characters in text.
    // The final inputted text is passed into the method.
    public static int countUpperCase(String userTextFinal)
    {
        // Declare variable to count number of upper case characters.
        int numberUpperCase = 0;
        // Loop progresses through final group of text (one character at a time).
        foreach (char upperCase in userTextFinal)
        {
            // Each time a declared character is found the count is increased by one.
            if (upperCase == 'A' || upperCase == 'B' || upperCase == 'C' || upperCase == 'D' || upperCase == 'E' || upperCase == 'F' || upperCase == 'G' || upperCase == 'H' || upperCase == 'I' || upperCase == 'J' || upperCase == 'K' || upperCase == 'L' || upperCase == 'M' || upperCase == 'N' || upperCase == 'O' || upperCase == 'P' || upperCase == 'Q' || upperCase == 'R' || upperCase == 'S' || upperCase == 'T' || upperCase == 'U' || upperCase == 'V' || upperCase == 'W' || upperCase == 'X' || upperCase == 'Y' || upperCase == 'Z')
            {
                numberUpperCase = numberUpperCase + 1;
            }

        }
        // Method returns the final count.
        return numberUpperCase;
    }

    // Method to count number of lower case characters in text.
    // The final inputted text is passed into the method.
    public static int countLowerCase(String userTextFinal)
    {
        // Declare variable to count number of lower case characters.
        int numberLowerCase = 0;
        // Loop progresses through final group of text (one character at a time).
        foreach (char lowerCase in userTextFinal)
        {
            // Each time a declared character is found the count is increased by one.
            if (lowerCase == 'a' || lowerCase == 'b' || lowerCase == 'c' || lowerCase == 'd' || lowerCase == 'e' || lowerCase == 'f' || lowerCase == 'g' || lowerCase == 'h' || lowerCase == 'i' || lowerCase == 'j' || lowerCase == 'k' || lowerCase == 'l' || lowerCase == 'm' || lowerCase == 'n' || lowerCase == 'o' || lowerCase == 'p' || lowerCase == 'q' || lowerCase == 'r' || lowerCase == 's' || lowerCase == 't' || lowerCase == 'u' || lowerCase == 'v' || lowerCase == 'w' || lowerCase == 'x' || lowerCase == 'y' || lowerCase == 'z')
            {
                numberLowerCase = numberLowerCase + 1;
            }

        }
        // Method returns the final count.
        return numberLowerCase;
    }

    // Method counts the number of each individual character.
    public static void numberOfCharacters(String userTextFinal)
    {
        // Declares a variable assigned to each individual letter. Enables counting of each individual letter.
        int aCount = 0;
        int bCount = 0;
        int cCount = 0;
        int dCount = 0;
        int eCount = 0;
        int fCount = 0;
        int gCount = 0;
        int hCount = 0;
        int iCount = 0;
        int jCount = 0;
        int kCount = 0;
        int lCount = 0;
        int mCount = 0;
        int nCount = 0;
        int oCount = 0;
        int pCount = 0;
        int qCount = 0;
        int rCount = 0;
        int sCount = 0;
        int tCount = 0;
        int uCount = 0;
        int vCount = 0;
        int wCount = 0;
        int xCount = 0;
        int yCount = 0;
        int zCount = 0;

        // Loops through the final text (userTextFinal), one character at a time. 
        foreach (char character in userTextFinal)
        {
            // Switch statement counts each individual character, upper and lower case. Increments letter counter if a match is found.
            switch (character)
            {
                case 'a':
                case 'A':
                    aCount ++;
                    break;
                case 'b':
                case 'B':
                    bCount++;
                    break;
                case 'c':
                case 'C':
                    cCount++;
                    break;
                case 'd':
                case 'D':
                    dCount++;
                    break;
                case 'e':
                case 'E':
                    eCount++;
                    break;
                case 'f':
                case 'F':
                    fCount++;
                    break;
                case 'g':
                case 'G':
                    gCount++;
                    break;
                case 'h':
                case 'H':
                    hCount++;
                    break;
                case 'i':
                case 'I':
                    iCount++;
                    break;
                case 'j':
                case 'J':
                    jCount++;
                    break;
                case 'k':
                case 'K':
                    kCount++;
                    break;
                case 'l':
                case 'L':
                    lCount++;
                    break;
                case 'm':
                case 'M':
                    mCount++;
                    break;
                case 'n':
                case 'N':
                    nCount++;
                    break;
                case 'o':
                case 'O':
                    oCount++;
                    break;
                case 'p':
                case 'P':
                    pCount++;
                    break;
                case 'q':
                case 'Q':
                    qCount++;
                    break;
                case 'r':
                case 'R':
                    rCount++;
                    break;
                case 's':
                case 'S':
                    sCount++;
                    break;
                case 't':
                case 'T':
                    tCount++;
                    break;
                case 'u':
                case 'U':
                    uCount++;
                    break;
                case 'v':
                case 'V':
                    vCount++;
                    break;
                case 'w':
                case 'W':
                    wCount++;
                    break;
                case 'x':
                case 'X':
                    xCount++;
                    break;
                case 'y':
                case 'Y':
                    yCount++;
                    break;
                case 'z':
                case 'Z':
                    zCount++;
                    break;
            }

        }

        // Prints the results of the analysis to the user. Each character is printed.
        Console.Write("\nNumber of A's = {0}", aCount);
        Console.Write("\nNumber of B's = {0}", bCount);
        Console.Write("\nNumber of C's = {0}", cCount);
        Console.Write("\nNumber of D's = {0}", dCount);
        Console.Write("\nNumber of E's = {0}", eCount);
        Console.Write("\nNumber of F's = {0}", fCount);
        Console.Write("\nNumber of G's = {0}", gCount);
        Console.Write("\nNumber of H's = {0}", hCount);
        Console.Write("\nNumber of I's = {0}", iCount);
        Console.Write("\nNumber of J's = {0}", jCount);
        Console.Write("\nNumber of K's = {0}", kCount);
        Console.Write("\nNumber of L's = {0}", lCount);
        Console.Write("\nNumber of M's = {0}", mCount);
        Console.Write("\nNumber of N's = {0}", nCount);
        Console.Write("\nNumber of O's = {0}", oCount);
        Console.Write("\nNumber of P's = {0}", pCount);
        Console.Write("\nNumber of Q's = {0}", qCount);
        Console.Write("\nNumber of R's = {0}", rCount);
        Console.Write("\nNumber of S's = {0}", sCount);
        Console.Write("\nNumber of T's = {0}", tCount);
        Console.Write("\nNumber of U's = {0}", uCount);
        Console.Write("\nNumber of V's = {0}", vCount);
        Console.Write("\nNumber of W's = {0}", wCount);
        Console.Write("\nNumber of X's = {0}", xCount);
        Console.Write("\nNumber of Y's = {0}", yCount);
        Console.Write("\nNumber of Z's = {0}", zCount);

    }


    // Method counts number of characters in words and outputs words longer than 7 characters into a text file. 
    public static void longWords(String userTextFinal)
    {
        // Declares the file name, file will be in same directory as the program.
        String fileDir = "Long_Words.txt";
        // Creates an array of all the words in the userTextFinal vaiable. Words are determined by the location of spaces.
        String[] words = userTextFinal.Split(' ');

        // Cycles through the array of words one at a time.
        foreach (String word in words)
        {
            // If the word length is greater than or equal to 7 the word is appended into the text file declared above.
            if (word.Length >= 7)
            {
                File.AppendAllText(fileDir,word + " ");
            }
        }

    }

    // Method collects data from each of the methods above and formats them for output.
    // The final inputted text is passed into the method.
    public static void performAnalysis(String userTextFinal)
    {
        int sentenceCount = textAnalysis.countSentences(userTextFinal);
        int vowelCount = textAnalysis.countVowels(userTextFinal);
        int consonantCount = textAnalysis.countConsonants(userTextFinal);
        int upperCaseCount = textAnalysis.countUpperCase(userTextFinal);
        int lowerCaseCount = textAnalysis.countLowerCase(userTextFinal);
        Console.Write("\nNumber Of Sentences = {0}", sentenceCount);
        Console.Write("\nNumber Of Vowels = {0}", vowelCount);
        Console.Write("\nNumber Of Consonants = {0}", consonantCount);
        Console.Write("\nNumber Of Upper Case Characters = {0}", upperCaseCount);
        Console.Write("\nNumber Of Lower Case Characters = {0}", lowerCaseCount);
        Console.Write("\n\nIndividual Characters\n");
        numberOfCharacters(userTextFinal);
    }
}
