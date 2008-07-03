using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 9818;
        public const long RetryLevel = 3144;
        public const string BaseTimeout = "latest-1";
        public const long CacheCluster = 3221;
        public const long DefaultCluster = 4748;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
