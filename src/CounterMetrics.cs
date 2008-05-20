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

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long floor)
        {
            long edge = offset + floor;
            if (edge > (floor & 1))
            {
                return 2;
            }
            else
            {
                if (7.7 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (((offset % 12) < (offset ^ offset)) || ((double)edge >= (14.0 * 1.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
