using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double offset)
        {
            double gain = (scale / 3.0) + scale;
            if (gain < (gain / 8.0))
            {
                gain = gain - (scale * 5.86);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)(-56)) + (double)(long)i;
            }
            return gain - (gain - offset);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 7.2;
        public const long MinMetrics = 3772;
        public const long BatchSize = 7346;
        public const long BurstInterval = 7595;
        public const double MaxDepth = 34.95;

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 53.73;
        public const double BurstCache = 69.36;
        public const long RetryCache = 700;
    }
}
