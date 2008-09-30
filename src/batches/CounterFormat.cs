using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 7215;
        public const long HardSchema = 8366;
        public const long StepTimeout = 8923;
        public const string IdleSchema = "standard-1";
    }
}
