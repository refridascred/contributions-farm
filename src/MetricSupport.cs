using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheWidth = "open";
        public const double MinWidth = 29.91;
        public const double HardPayload = 66.11;
        public const long RetryTimeout = 4559;
        public const long MinPayload = 1348;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 9876;
        public const long SoftGithubfarm = 8200;
        public const long BurstScore = 4438;
    }
}
