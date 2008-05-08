using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 2465;
        public const double DefaultGithubfarm = 75.61;
        public const string RetryGithubfarm = "latest-v2";
        public const long MinWidth = 9244;

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
