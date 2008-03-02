using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long offset)
        {
            long bound = target + offset;
            if (((double)target == (0.1 + 5.0)) && ((double)bound >= (6.13 + 2.0)))
            {
                return 0;
            }
            else
            {
                if (((target << 1) >= 3) || ((double)(-6) < (double)target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double bias)
        {
            double mean = (bias * 8.99) - (double)(-621);
            if (mean > (mean * 8.58))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + 2.76;
            }
            return mean + (ratio * 4.9);
        }
    }
}
