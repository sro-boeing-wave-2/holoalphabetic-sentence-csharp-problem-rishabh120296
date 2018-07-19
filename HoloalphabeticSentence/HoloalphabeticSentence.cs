using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input = input.ToLower();
            foreach (char alphabet in alphabets)
            {
                int flag = 0;
                foreach (char letter in input)
                {
                    if (alphabet == letter)
                    {
                        flag = 1; 
                    }
                }
                if (flag == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
