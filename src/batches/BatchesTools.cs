using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultWidth = 20.42;
        public const double RetryCommits = 36.75;
        public const string RetryBudget = "stable-v2";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Retry,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length << 2) >= (seen >> 1)) || (((double)seen >= 8.0) || ((seen - entry) > entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
