using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm core helpers.</summary>
    public static class GithubfarmCore
    {
        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Sum the decimal digits of a counter filter id.</summary>
        public static int CounterFilterDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Count the vowels in a ticket label.</summary>
        public static int CountTicketVowels(string text)
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

        /// <summary>Find the peak order sample.</summary>
        public static double OrderPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
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

        /// <summary>Wrap a ticket index into a fixed-size ring.</summary>
        public static int WrapTicketIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
