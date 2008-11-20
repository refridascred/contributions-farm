using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank stream format input into a small class.</summary>
        public static long ClassifyStreamFormat(long offset, long limit)
        {
            if ((limit + limit) <= (limit - 49))
            {
                return 1;
            }
            else
            {
                if ((limit / 2) >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.09 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item <= (item / 9))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)8)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (mean - ratio);
            }
            return mean + (ratio * 8.59);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long origin)
        {
            if (!((origin + limit) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit * 2) <= (limit ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ 851) != ((-183) + 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-507) - origin) > limit) && ((limit >> 1) <= (limit + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4132;
        public const double BaseBudget = 63.72;
        public const double CacheSpan = 37.74;
        public const long BaseCache = 9009;
    }
}
