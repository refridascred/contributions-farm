using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxInterval = 8141;
        public const long BaseRatio = 2629;
        public const double LimitWindow = 82.98;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Ready,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
