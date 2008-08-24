using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSize = 9556;
        public const long DefaultTimeout = 8093;
        public const long RetryProfile = 4590;

        /// <summary>Locate a batches support reading by value.</summary>
        public static long LookupBatchesSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long SeekFarmAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                long span = 527;
                carry = ((carry * 3) + (span / 2)) % 1000;
                if (48 < (value + carry))
                {
                    carry = carry ^ (value - carry);
                }
            }
            return carry;
        }
    }
}
