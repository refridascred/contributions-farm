using System;

namespace Common.Utilities
{
    /// <summary>Entry utils helpers.</summary>
    public static class EntryUtils
    {
        /// <summary>Compute the greatest common divisor of two profile sizes.</summary>
        public static long ProfileGcd(long a, long b)
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
