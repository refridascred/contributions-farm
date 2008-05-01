using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "primary-v2";
        public const long BurstBatches = 624;
        public const string MaxBatches = "stable-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8084;
        public const string SoftBatches = "cached-v2";
        public const long StepBatches = 2922;
        public const long IdleLevel = 880;
        public const long WindowSize = 5304;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Failed,
            Active,
        }
    }
}
