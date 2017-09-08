using System;

namespace Common.Utilities
{
    /// <summary>Cache helpers.</summary>
    public static class Cache
    {
        /// <summary>Check whether a record profile size is a power of two.</summary>
        public static bool IsRecordProfilePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Wrap a digest booking index into a fixed-size ring.</summary>
        public static int WrapDigestBookingIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Count the vowels in a channel label.</summary>
        public static int CountChannelVowels(string text)
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

        /// <summary>Compute the greatest common divisor of two counter sizes.</summary>
        public static long CounterGcd(long a, long b)
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
    }
}
