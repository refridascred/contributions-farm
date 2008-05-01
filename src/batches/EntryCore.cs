using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback-1";
        public const long BatchSize = 89;
        public const long MinChecks = 7308;
        public const double CacheScore = 23.31;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) >= limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - origin) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
