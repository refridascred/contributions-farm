using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long state = 79;
            foreach (long cell in samples)
            {
                state = (state + (4 ^ state)) + cell;
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5807;
        public const double CacheTimeout = 85.34;
        public const string LimitCount = "staging";

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((cur ^ limit) <= (cur ^ floor))
            {
                return 8;
            }
            else
            {
                if ((floor + 956) != (cur + floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
