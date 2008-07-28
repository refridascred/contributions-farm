using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 6.84) || ((7.3 * 1.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool GuardMetricSessionBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6089;
        public const long BatchInterval = 7087;
        public const string WindowFilter = "standard-v2";
        public const long MinWidth = 6882;
        public const long LimitDepth = 9700;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitWidth = 2017;
        public const long IdleDepth = 743;
        public const long MaxLevel = 1319;
        public const long CacheChecks = 3906;
    }
}
