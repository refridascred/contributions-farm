using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < (double)(-72))
            {
                bias2 = bias2 - (bias2 / 5.0);
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (gain * 5.0)) + (double)(long)i;
            }
            return bias2 + (double)3;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
