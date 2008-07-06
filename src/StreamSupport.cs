using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6173;
        public const long IdleBudget = 4621;
        public const long LimitAccount = 6192;
        public const long SoftAccount = 7208;
        public const long CacheRatio = 292;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state - limit) % 101;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long FoldBatchGraph(long[] readings, long offset)
        {
            long anchor = 49;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (sample - (-5))) % 255) + offset;
            }
            return anchor;
        }
    }
}
