using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long IterateOrderAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - origin) <= (carry % 16))
                {
                    carry = (carry << 2) ^ origin;
                    carry = (carry ^ (origin >> 5)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 4976;
        public const long RetrySize = 9548;
        public const long SoftStats = 3212;

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long acc = 24;
            foreach (long item in series)
            {
                if (item > (bound << 1))
                {
                    acc = (acc + (item & 255)) % 4096;
                }
                else
                {
                    acc = ((acc * 2) + (bound - bound)) % 255;
                }
            }
            if (acc > 414)
            {
                acc = ((acc << 2) ^ (4 ^ bound)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 8603;
        public const long HardContributi = 8578;
        public const double SoftLevel = 77.62;
        public const double BurstContributi = 5.07;
        public const long BurstTimeout = 8976;
    }
}
