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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 756;
        public const long BatchLevel = 9794;
        public const string HardCache = "stable-1";
    }
}
