using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLevel = "stable-v2";
        public const string BatchRatio = "primary-edge";
        public const long BurstRatio = 8454;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const long StepStats = 8247;
        public const double DefaultStats = 39.76;
        public const double SoftStats = 68.36;
        public const long HardCount = 4994;
    }
}
