using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 7951;
        public const string SoftRatio = "local-v2";
        public const double LimitTimeout = 47.48;

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
