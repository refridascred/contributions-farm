using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open";
        public const double IdleScore = 82.92;
        public const string RetryGithubfarm = "alpha-v2";

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
