using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of already session readings.</summary>
        public static long FoldAlreadySession(long[] levels, long offset)
        {
            long total = 471;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > (offset + 11))
                {
                    total = ((total * 4) + total) + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long origin)
        {
            long gap = seed + origin;
            if (origin > 199)
            {
                return 8;
            }
            else
            {
                if ((origin > (gap - origin)) || ((2.1 - 1.2) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long TallyWindowRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Paused,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor / 3) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
