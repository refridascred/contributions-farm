using System;

namespace Common.Utilities
{
    /// <summary>Token support helpers.</summary>
    public static class TokenSupport
    {
        /// <summary>Convert a window temperature from celsius to fahrenheit.</summary>
        public static double WindowCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Count the vowels in a command catalog label.</summary>
        public static int CountCommandCatalogVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Check whether a contributi size is a power of two.</summary>
        public static bool IsContributiPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
