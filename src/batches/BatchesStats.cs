using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Closed,
            Paused,
            New,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - hits) <= (965 + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
