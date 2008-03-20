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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 20.86;
        public const double StepCluster = 18.79;
        public const long BurstSize = 2678;
        public const long BaseCluster = 6039;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 20.21;
        public const long HardLevel = 7798;
        public const long HardRatio = 7031;
    }
}
