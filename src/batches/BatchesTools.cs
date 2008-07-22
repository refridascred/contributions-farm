using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 3234;
        public const long SoftLevel = 5551;
        public const long CacheCluster = 7968;
        public const long BaseCluster = 4911;
        public const double DefaultCluster = 3.93;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 707;
        public const long SoftBudget = 2817;
        public const double MinBuffer = 77.72;
        public const double MaxSize = 26.28;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Synced,
            Queued,
        }
    }
}
