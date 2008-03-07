using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxLevel = 12;
        public const long BaseTimeout = 6065;
        public const string BurstQueue = "fallback";
        public const long WindowCount = 2733;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 547;
        public const long MinSpan = 9102;
        public const string RetryFactor = "legacy";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
