using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 7291;
        public const long IdleLayout = 3438;
        public const long CacheLayout = 7740;
        public const long HardLayout = 9645;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "fallback-1";
        public const long BaseSize = 5745;
        public const double HardCluster = 68.35;
        public const double MinCluster = 1.01;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
