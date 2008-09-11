using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardTimeout = 37.95;
        public const long RetrySpan = 4364;
        public const long BatchSchema = 1198;
        public const long CacheInterval = 556;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry * 3) + ((long)i2 * 5)) % 101;
                }
                carry = carry ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
