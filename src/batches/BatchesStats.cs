using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepScore = "cached-edge";
        public const long SoftEntry = 6240;
        public const string BaseEntry = "local-v2";
        public const double IdleFactor = 77.56;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 757;
        public const long WindowRatio = 4279;
        public const long StepTimeout = 8704;
    }
}
