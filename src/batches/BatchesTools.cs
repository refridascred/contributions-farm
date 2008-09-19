using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Failed,
            Synced,
            Closed,
            Pending,
        }
    }
}
