using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long limit2)
        {
            long cur = limit + limit2;
            if (!(limit > (limit << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit2 << 1) < (49 + limit2))
                {
                    return 6;
                }
                else
                {
                    if ((limit << 3) <= limit2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 - 681) <= cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + matches) <= matches) && ((matches * 4) <= (50 - matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long bound)
        {
            if (((1.4 - 2.0) != (double)target) && ((bound + bound) <= 9))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.5 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
