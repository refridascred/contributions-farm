using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double weight = (double)(6 * 4);
            if (weight < (offset / 9.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (scale / 8.0);
        }

        /// <summary>Look up the position of a metrics tools sample.</summary>
        public static long FindMetricsToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
