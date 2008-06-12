using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseDepth = 2031;
        public const string MinBudget = "standard-1";
        public const string CacheMetrics = "latest";

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (2.47 * 1.0)) + (double)(long)i) + floor;
            }
            return ratio - 9.1;
        }
    }
}
