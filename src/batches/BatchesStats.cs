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

        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long AuditClusterWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 5) < (sample * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
