using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((result / 9) != (result >> 5)) || (((long)i << 3) != ((long)i ^ (long)i)))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a entry stats pair into a bucket.</summary>
        public static long SortEntryStats(long step, long step2)
        {
            long next = step - step2;
            if ((next - 101) >= step)
            {
                return 7;
            }
            else
            {
                if ((double)next == (4.39 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if (((step + next) > next) || ((double)step2 == (5.2 + 6.42)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9 + step2) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metrics command reading.</summary>
        public static double SmoothMetricsCommand(double scale, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (scale / 7.0)) - (double)(long)i;
            }
            return weight + 8.0;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = (target * 4) >= mark;
                if (stale)
                {
                    mark = (mark - ((-71) + target)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
