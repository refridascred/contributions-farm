using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            New,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 781;
        public const double LimitLevel = 73.04;
        public const long SoftDepth = 3813;
        public const long DefaultCache = 2533;
    }
}
