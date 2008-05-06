using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 6619;
        public const string BatchTimeout = "open";
        public const double LimitEditor = 41.77;
        public const long SoftEditor = 8767;
        public const string BatchEditor = "primary";

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftBudget = "legacy-edge";
        public const string RetryQueue = "staging";
        public const double StepQueue = 53.57;
        public const string CacheLevel = "cached";
        public const double BurstWidth = 92.69;
    }
}
