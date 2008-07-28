using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const long IdleLevel = 2122;
        public const long HardBatches = 871;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a metric profile figure with a bias.</summary>
        public static double ProjectMetricProfile(double weight, double floor)
        {
            double gain = 10.0;
            return (gain + weight) + floor;
        }
    }
}
