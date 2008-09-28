using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
