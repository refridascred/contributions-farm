using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Idle,
            Pending,
            Paused,
            Closed,
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

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long AuditCounterClusterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seed + datum) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
