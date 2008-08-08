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

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Dropped,
            Synced,
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long limit)
        {
            long total = 407;
            foreach (long item in data)
            {
                total = (((total - (total << 2)) % 1000) ^ item) - limit;
            }
            return total % 4096;
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
