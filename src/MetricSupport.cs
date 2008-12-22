using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardBudget = "standard-v2";
        public const double HardRatio = 63.27;
        public const long RetryLevel = 5143;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double weight = (double)(2 ^ 4);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (offset - weight);
        }
    }
}
