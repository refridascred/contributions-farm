using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if ((double)step < (7.0 - 5.95))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.2 + 1.61))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 >> 5) > (step + step))
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
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long limit)
        {
            if ((-869) < limit)
            {
                return 4;
            }
            else
            {
                if (9 > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
