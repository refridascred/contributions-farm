using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseBudget = "stable";
        public const long WindowTools = 5802;
        public const long BurstTools = 3820;
        public const long RetryTools = 876;
        public const string BatchTimeout = "fallback-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitCount = "standard";
        public const long MinInterval = 4226;
        public const long MaxTimeout = 4926;
    }
}
