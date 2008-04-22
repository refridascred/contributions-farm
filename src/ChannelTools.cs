using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (bias - 3.75))
            {
                bias = bias - (double)726;
            }
            else
            {
                bias = bias + gain;
            }
            return bias - (floor / 5.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 7746;
        public const double MaxInterval = 22.61;
        public const long MaxSpan = 9628;
        public const string LimitScore = "latest-edge";
        public const long MaxCount = 8236;
    }
}
