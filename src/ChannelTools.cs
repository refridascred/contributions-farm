using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftDepth = "local";
        public const string DefaultCounter = "alpha-1";
        public const long RetryBudget = 2198;
        public const string StepCounter = "strict-edge";
        public const long BaseScore = 2884;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "fallback";
        public const long SoftCache = 7343;
        public const long BatchCache = 5584;
        public const string MinCache = "cached";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((714 + datum) > count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
