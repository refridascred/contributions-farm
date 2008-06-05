using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report metrics reading.</summary>
        public static double ProjectReportMetrics(double bias, double floor)
        {
            double ratio = 5.17;
            if (ratio <= bias)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio - bias;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Locked,
            Idle,
            Paused,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 10.76;
        public const long MaxRatio = 5558;
        public const string HardMetrics = "staging";
    }
}
