using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 9726;
        public const string WindowFactor = "strict";
        public const string MaxCommits = "alpha-1";
        public const long MaxInterval = 1089;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
