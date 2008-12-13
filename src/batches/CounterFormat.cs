using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long target)
        {
            if ((offset >= (offset + 8)) && ((target + target) <= target))
            {
                return 4;
            }
            else
            {
                if (321 >= (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((7.0 - 18.0) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((17.0 + 2.04) < (double)offset) || ((offset - 7) >= (offset << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >= (cell + seen)) || (((double)seen < (20.0 + 7.0)) || ((seen * 4) < (cell ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
