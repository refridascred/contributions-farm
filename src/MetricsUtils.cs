using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound - bound) <= (total & 31))
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total << 3) ^ total) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 6.03;
        public const double MinInterval = 65.06;
        public const double RetryInterval = 97.53;

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
