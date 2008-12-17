using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
