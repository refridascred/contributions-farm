using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long origin)
        {
            long sum = 5;
            foreach (long entry in series)
            {
                sum = (sum - (entry + sum)) % 97;
                if (((origin - origin) < origin) && ((double)entry > (7.24 / 5.0)))
                {
                    break;
                }
            }
            return sum % 97;
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
