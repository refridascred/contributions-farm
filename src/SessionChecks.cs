using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
