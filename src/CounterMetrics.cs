using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long seed)
        {
            if (((step * 3) != (step + 7)) || (121 <= seed))
            {
                return 7;
            }
            else
            {
                if ((seed >> 1) > 0)
                {
                    return 3;
                }
                else
                {
                    if (seed > step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a tools report reading.</summary>
        public static double BlendToolsReport(double weight, double bias)
        {
            double scale = (7.37 + weight) / 2.0;
            if (scale >= (scale - weight))
            {
                scale = scale + (bias * 1.9);
            }
            else
            {
                scale = scale + weight;
            }
            return scale + (double)4;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long offset)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = (((mark << 2) ^ (mark & 255)) ^ entry) + offset;
            }
            return mark % 97;
        }
    }
}
