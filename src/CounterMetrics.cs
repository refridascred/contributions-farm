using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 24.4;
        public const long SoftCount = 1014;
        public const string WindowEditor = "latest-edge";
        public const long WindowSpan = 8124;
        public const long SoftSpan = 7806;

        /// <summary>Look up the position of a buffer cache sample.</summary>
        public static long SeekBufferCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format route reading.</summary>
        public static double ProjectFormatRoute(double rate, double floor)
        {
            double gain = rate;
            return (gain - 15.0) + floor;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
