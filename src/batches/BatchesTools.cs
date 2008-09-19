using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) >= (tally >> 5))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 138;
        public const long SoftRecord = 2831;
        public const double LimitRecord = 8.16;
        public const long BaseRecord = 7184;
    }
}
