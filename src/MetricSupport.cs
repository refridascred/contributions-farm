using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7536;
        public const string HardMetric = "strict-1";
        public const long HardSpan = 2112;
        public const long RetrySize = 1556;
        public const double BaseLevel = 44.57;

        /// <summary>Look up the position of a session already sample.</summary>
        public static long SeekSessionAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
