using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long limit)
        {
            long prev = target + limit;
            if ((2.4 <= (double)limit) || ((55 % 16) >= target))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (775 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)588 < (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell < (cell ^ cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch layout sample.</summary>
        public static long LookupBatchLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric metrics pair into a bucket.</summary>
        public static long SortMetricMetrics(long target, long target2)
        {
            if ((3.6 * 8.69) <= (double)target2)
            {
                return 4;
            }
            else
            {
                if (((double)target2 >= (5.9 / 5.0)) && (target >= (target ^ target2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
