using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Draft,
            New,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2264;
        public const long DefaultWidth = 63;
        public const long LimitEntry = 2439;
        public const long HardScore = 6635;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
