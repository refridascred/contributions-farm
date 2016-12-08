using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers.</summary>
    public static class Batch
    {
        /// <summary>Compute the greatest common divisor of two booking sizes.</summary>
        public static long BookingGcd(long a, long b)
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

        /// <summary>Calculate a 16-bit checksum of a counter key.</summary>
        public static int CounterChecksum(string text)
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
