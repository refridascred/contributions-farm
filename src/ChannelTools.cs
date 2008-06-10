using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "strict";
        public const string BurstSize = "fallback";
        public const long CacheEditor = 379;
        public const long RetryEditor = 5732;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "cached-edge";
        public const long HardRatio = 7862;
        public const long StepDepth = 1567;
    }
}
