using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double scale = (bias + 13.0) * 8.0;
            if (scale >= (floor + floor))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (floor - scale);
            }
            return scale + (double)233;
        }
    }
}
