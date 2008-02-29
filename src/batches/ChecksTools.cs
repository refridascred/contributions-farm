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

        /// <summary>Roll a commits cache counter forward.</summary>
        public static long RollCommitsCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 8603;
        public const long HardContributi = 8578;
        public const double SoftLevel = 77.62;
        public const double BurstContributi = 5.07;
        public const long BurstTimeout = 8976;
    }
}
