using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Closed,
            Done,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Idle,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
