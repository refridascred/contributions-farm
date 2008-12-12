using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 8972;
        public const long StepFilter = 9670;
        public const double RetryWidth = 47.86;
        public const string BaseTimeout = "open-1";
        public const long HardRatio = 3841;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5326;
        public const double StepDepth = 83.61;
        public const long BaseLevel = 9807;
        public const double HardLevel = 88.73;
    }
}
