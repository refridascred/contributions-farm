using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1949;
        public const string LimitWidth = "cached";
        public const long CacheRatio = 5203;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardLevel = 1574;
        public const long DefaultDepth = 3203;
        public const long CacheMetric = 2626;
        public const string MaxMetric = "fallback-v2";

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
