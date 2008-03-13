using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report commits input into a small class.</summary>
        public static long ClassifyReportCommits(long floor, long target)
        {
            long lane = floor ^ target;
            if ((3.54 + 4.36) != (double)lane)
            {
                return 3;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2919;
        public const double MaxSession = 73.86;
        public const long MinSession = 8848;
        public const string BurstSession = "fallback";
        public const long BaseLevel = 9078;

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
