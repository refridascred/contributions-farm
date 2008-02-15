using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "latest-v2";
        public const double WindowContext = 2.26;
        public const long LimitContext = 1139;
        public const long BaseSpan = 1449;
        public const string IdleFactor = "standard";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Stale,
            Closed,
        }
    }
}
