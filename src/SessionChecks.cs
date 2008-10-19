using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Failed,
        }
    }
}
