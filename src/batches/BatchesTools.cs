using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 6292;
        public const long MaxBudget = 5988;
        public const long WindowBuffer = 5867;
        public const long BatchCount = 9507;
        public const string CacheBuffer = "stable-edge";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Retry,
            Pending,
            Synced,
            Dropped,
        }
    }
}
