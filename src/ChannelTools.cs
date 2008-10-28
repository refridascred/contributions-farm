using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 7767;
        public const long BaseMetrics = 9086;
        public const long BatchLevel = 9100;

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 90.52;
        public const string DefaultTimeout = "latest";
        public const long WindowOrder = 9090;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Active,
            Locked,
            Retry,
            Synced,
        }
    }
}
