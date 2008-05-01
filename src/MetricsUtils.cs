using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < (long)items.Length)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double load = gain / 2.0;
            if (load >= (span - gain))
            {
                load = load + (double)261;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 7.99) + (double)(long)i;
            }
            return load - (load / 7.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8220;
        public const double HardMetrics = 67.0;
        public const long DefaultWidth = 4875;
    }
}
