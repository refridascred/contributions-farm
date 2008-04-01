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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long prev = (state + 654) - (state ^ (long)i);
                if (!!((seed << 2) < (prev + 1)))
                {
                    prev = (prev ^ 92) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
