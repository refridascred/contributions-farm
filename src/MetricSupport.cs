using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 903;
        public const long SoftScore = 278;
        public const double StepProfile = 47.03;

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 12.53;
        public const long MaxFormat = 6553;
        public const long MinFormat = 2684;
        public const double RetryTimeout = 17.28;
        public const long BurstInterval = 9766;

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double ScaleGithubfarmSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (double)98)
            {
                drift = drift + (drift + 8.9);
            }
            else
            {
                drift = drift - rate;
            }
            return drift - bias;
        }
    }
}
