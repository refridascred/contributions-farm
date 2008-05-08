using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchWidth = 7.38;
        public const string RetryLevel = "cached-v2";
        public const long MaxSize = 4796;
        public const string RetryFarm = "local-v2";

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2533;
        public const long LimitWidth = 3454;
        public const long CacheBatches = 7820;
        public const long WindowBatches = 9968;
        public const long BurstBatches = 3125;
    }
}
