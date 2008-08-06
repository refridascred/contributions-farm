using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Stale,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8729;
        public const string HardGithubfarm = "strict-1";
        public const double BaseGithubfarm = 12.9;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
