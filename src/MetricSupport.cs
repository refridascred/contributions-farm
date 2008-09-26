using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Done,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
