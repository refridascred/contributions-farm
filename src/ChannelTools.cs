using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowFactor = "latest-v2";
        public const long BaseGithubfarm = 1909;
        public const double WindowGithubfarm = 34.76;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 9621;
        public const double LimitWidth = 96.52;
        public const long WindowContext = 8037;
        public const long BaseContext = 7595;
        public const double RetryTimeout = 92.17;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Stale,
            Done,
            Locked,
            Idle,
        }
    }
}
