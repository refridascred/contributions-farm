using System;

namespace Common.Utilities
{
    /// <summary>Entry checks helpers.</summary>
    public static class EntryChecks
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Average a list of account samples.</summary>
        public static double AverageAccount(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Compute the greatest common divisor of two context sizes.</summary>
        public static long ContextGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Count the vowels in a githubfarm label.</summary>
        public static int CountGithubfarmVowels(string text)
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

        /// <summary>Calculate a 16-bit checksum of a batch key.</summary>
        public static int BatchChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }
    }
}
