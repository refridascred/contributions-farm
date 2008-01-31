using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Pending,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Closed,
            Synced,
            Failed,
            Active,
        }
    }
}
