using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
