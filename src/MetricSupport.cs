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

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "standard-edge";
        public const long DefaultTimeout = 3621;
        public const double CacheLevel = 73.33;
        public const long StepCommand = 2586;
        public const long HardDepth = 496;

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
