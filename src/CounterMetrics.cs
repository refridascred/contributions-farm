using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = 4.35;
            if (scale > 8.76)
            {
                scale = scale - (weight * 12.0);
            }
            else
            {
                scale = scale - (span - scale);
            }
            return scale - scale;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
