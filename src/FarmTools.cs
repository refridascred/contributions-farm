using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 3118;
        public const long BurstDepth = 9433;
        public const string IdleRatio = "cached-1";
        public const long DefaultEditor = 185;
        public const long IdleEditor = 8003;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((1 + 8) >= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
