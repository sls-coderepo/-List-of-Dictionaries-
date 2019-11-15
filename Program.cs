using System;
using System.Collections.Generic;

namespace ListofDictionariesaboutWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("Happy", "feeling or showing pleasure or contentment.");
            excitedWord.Add("Awesome", "The feeling of students when they are learning C#");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);
            // create another Dictionary and add that to the list
            Dictionary<string, string> sadWords = new Dictionary<string, string>();

            sadWords.Add("Sad", "feeling or showing sorrow");
            sadWords.Add("unhappy", "not happy");

            dictionaryOfWords.Add(sadWords);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */
            /*  foreach (KeyValuePair<string, string> word in excitedWord)
             {
                 Console.WriteLine($"{word.Key} {word.Value}");
             }

             foreach (KeyValuePair<string, string> word in sadWords)
             {
                 Console.WriteLine($"{word.Key} {word.Value}");
             } */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> dictionary in dictionaryOfWords)
            {
                foreach (KeyValuePair<string, string> wordData in dictionary)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }

            }

        }
    }
}