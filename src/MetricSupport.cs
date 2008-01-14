using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
