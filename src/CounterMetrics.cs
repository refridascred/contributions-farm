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

        /// <summary>Derive the next route profile value from a seed.</summary>
        public static long SeriesRouteProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if (((step + step) == (step + acc)) || ((acc / 7) == (step >> 2)))
                {
                    acc = acc + step;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double bias)
        {
            double gain = bias;
            if (gain > ratio)
            {
                gain = gain + (ratio * 2.67);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio / 5.0)) - (double)(long)i;
            }
            return gain - (6.0 - 1.5);
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
