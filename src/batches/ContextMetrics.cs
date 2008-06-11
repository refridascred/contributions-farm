using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitSize = 82.3;
        public const string SoftRatio = "legacy-1";
        public const double BaseCount = 22.89;
        public const double RetryAlready = 79.57;
        public const long BaseBudget = 9532;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSize = 616;
        public const double CacheCount = 95.88;
        public const double LimitRatio = 82.44;
        public const string BaseBuffer = "standard-v2";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = (bias - bias) + ratio;
            }
            return bias - (double)686;
        }
    }
}
