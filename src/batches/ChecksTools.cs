using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Active,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "fallback";
        public const long DefaultMetrics = 5328;
        public const string MinMetrics = "cached";
        public const long IdleMetrics = 9174;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Closed,
            Draft,
            Done,
        }
    }
}
