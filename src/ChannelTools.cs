using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Retry,
            Active,
        }

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
