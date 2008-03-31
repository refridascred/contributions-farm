using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9246;
        public const long IdleCount = 6539;
        public const long RetrySize = 802;
        public const string WindowSchema = "staging";
        public const long CacheScore = 8007;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (333 >= (cell * 4))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
