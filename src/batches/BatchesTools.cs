using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            New,
            Stale,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Failed,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
