using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 37.81;
        public const double RetryScore = 92.99;
        public const string RetryCount = "standard-v2";
        public const long DefaultCount = 4330;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long result = 56;
            foreach (long reading in levels)
            {
                result = ((result - (921 + result)) % 97) - reading;
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
