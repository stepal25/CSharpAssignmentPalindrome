using System;

namespace CSharpAssignmentPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            Console.WriteLine("Enter String: ");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("---------------");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
                rev += s[i].ToString(); // the += will add itself (variable) to the otherside of = sign
                                        // = rev = rev + s[i].ToSting);
            }
            Console.WriteLine(rev);
            if (s == rev)
            {
                Console.WriteLine("It is a palindrome. Entered String is : {0} and the reverse string is : {1} ", s, rev);
            }
            else
            {
                Console.WriteLine("It is not a palindrome. Entered String is : {0} and the reverse string is : {1} ", s, rev);
            }
        }
    }
}
