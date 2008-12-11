using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseRatio = 56.57;
        public const long StepGithubfarm = 9469;
        public const long HardGithubfarm = 1019;
        public const double CacheGithubfarm = 24.99;
        public const string IdleInterval = "standard-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "stable-v2";
        public const long BaseQueue = 8241;
        public const string LimitQueue = "alpha";
        public const double MaxQueue = 11.19;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
