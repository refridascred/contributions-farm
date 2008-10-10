using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((4.0 * 6.0) > (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryWidth = 2762;
        public const long MaxMetrics = 6348;
        public const long BaseCount = 6838;
        public const long BaseBudget = 3992;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Adjust a githubfarm stats reading.</summary>
        public static double BlendGithubfarmStats(double bias, double offset)
        {
            double load = 14.0 * 17.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (load * 15.0)) + (double)(long)i) - bias;
            }
            return load - (offset - 7.21);
        }
    }
}
