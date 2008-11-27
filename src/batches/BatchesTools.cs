using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 5419;
        public const string MinRatio = "open-edge";
        public const string IdleDepth = "legacy-edge";

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Retry,
            Pending,
            New,
            Stale,
        }
    }
}
