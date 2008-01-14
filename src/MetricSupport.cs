using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double ScaleSupportOrder(double scale, double bias)
        {
            double gain = (double)(882 & 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - scale) + bias;
            }
            return gain + (2.06 / 9.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitInterval = 73.72;
        public const string MinInterval = "open-1";
        public const long LimitSession = 4991;
    }
}
