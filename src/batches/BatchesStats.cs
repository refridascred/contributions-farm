using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 95.58;
        public const string WindowBudget = "standard-1";
        public const long CacheSpan = 8970;
        public const long BurstMetrics = 5851;
        public const long BatchMetrics = 2570;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 7550;
        public const long BaseCount = 1185;
        public const string LimitGithubfarm = "legacy-1";
        public const long BatchGithubfarm = 612;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Project the next queue format value.</summary>
        public static double ScaleQueueFormat(double ratio, double floor)
        {
            double load = 1.9;
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (16.0 * 9.62)) + (double)(long)i) + ratio) - floor;
            }
            return load - (double)29;
        }
    }
}
