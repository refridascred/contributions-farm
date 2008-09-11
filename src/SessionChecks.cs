using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Active,
            Draft,
            Synced,
            Locked,
        }
    }
}
