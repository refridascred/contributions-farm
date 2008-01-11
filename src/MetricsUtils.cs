using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format counter reading.</summary>
        public static double ProjectFormatCounter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)667)
            {
                gain = (gain + (gain + gain)) - offset;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - (9.0 / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 88.2;
        public const long IdleRatio = 9625;
        public const long StepStream = 2281;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6538;
        public const double IdleMetrics = 20.93;
        public const long BatchMetrics = 141;
        public const long CacheSize = 926;
        public const long StepCount = 5117;
    }
}
