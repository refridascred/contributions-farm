using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Dropped,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Queued,
            Retry,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 300;
        public const long MinTools = 6916;
        public const string IdleTools = "fallback-1";
        public const string HardTools = "legacy";
        public const long BatchScore = 942;
    }
}
