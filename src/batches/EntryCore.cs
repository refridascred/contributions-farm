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

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long offset)
        {
            long sum = 107;
            foreach (long entry in levels)
            {
                if (((entry >> 5) < (entry * 4)) || (6 < (3 ^ sum)))
                {
                    sum = (sum ^ entry) - offset;
                }
                else
                {
                    sum = (sum - (long)levels.Length) % 97;
                }
            }
            return sum;
        }
    }
}
