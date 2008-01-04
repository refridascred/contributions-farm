using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values, long origin)
        {
            long result = 0;
            foreach (long sample in values)
            {
                if ((5.8 / 3.0) <= (double)result)
                {
                    result = ((result - (45 + 916)) ^ sample) + origin;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long BucketRecordCounter(long offset, long origin)
        {
            if (origin > (offset >> 3))
            {
                return 3;
            }
            else
            {
                if ((origin - 722) >= (origin + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 9.39)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 >= (origin ^ origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
