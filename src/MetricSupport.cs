using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double offset)
        {
            double drift = (double)87 - (offset + offset);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (offset / 6.0);
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
