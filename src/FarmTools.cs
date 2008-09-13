using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 82.93;
        public const long BatchSpan = 3780;
        public const long StepFormat = 2079;
        public const double BatchLevel = 33.14;
        public const long IdleLevel = 9122;
    }
}
