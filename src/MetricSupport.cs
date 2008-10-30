using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double bias = 9.0;
            if (bias <= gain)
            {
                bias = bias + (floor * 18.0);
            }
            else
            {
                bias = bias + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)6) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
