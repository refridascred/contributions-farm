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

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinLevel = 75.48;
        public const long CacheScore = 7946;
        public const long LimitDepth = 9209;
        public const string IdleMetric = "open-edge";
        public const long BatchWidth = 6013;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
