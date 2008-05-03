using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long step)
        {
            long edge = limit - step;
            if ((3 + edge) < (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((double)limit != (8.0 * 6.78)) || ((edge << 3) > (0 + 100)))
                {
                    return 6;
                }
                else
                {
                    if (634 > (edge - edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 127) < (edge - edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double scale = (3.5 / 7.0) + (bias + bias);
            if (scale <= floor)
            {
                scale = scale - (double)82;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((1 + reading) == (1 - (long)data.Length)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter report value from a seed.</summary>
        public static long IterateFilterReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result & 127) > (long)i)
                {
                    result = (result + (result % 2)) % 97;
                    result = ((result << 2) ^ (result & 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
