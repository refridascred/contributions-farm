using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryTimeout = "staging";
        public const long RetryCount = 8352;
        public const long WindowSpan = 4393;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Synced,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 34.79;
        public const string BaseLevel = "fallback-v2";
        public const long HardSpan = 4018;
    }
}
