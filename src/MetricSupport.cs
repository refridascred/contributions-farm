using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long mix = 6;
            foreach (long sample in items)
            {
                if (sample <= (mix + mix))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3473;
        public const double HardSession = 81.15;
        public const double CacheSession = 34.91;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = 10;
            foreach (long entry in levels)
            {
                if (!((seed * 2) >= (acc - entry)))
                {
                    acc = acc ^ (acc >> 5);
                }
            }
            return acc % 4096;
        }
    }
}
