using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2589;
        public const long LimitScore = 3207;
        public const long BatchRoute = 4733;
        public const long RetryFactor = 5239;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double offset)
        {
            double rate2 = (7.94 - offset) - 1.3;
            return (rate2 - (double)78) + rate;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
