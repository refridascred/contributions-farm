using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((17.0 * 14.0) >= (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
