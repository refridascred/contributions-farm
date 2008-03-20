using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            New,
            Done,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1183;
        public const string BurstFactor = "fallback-1";
        public const long CacheContext = 7444;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 20.21;
        public const long HardLevel = 7798;
        public const long HardRatio = 7031;
    }
}
