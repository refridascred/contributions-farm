using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the buffer batches entries that pass the check.</summary>
        public static long AuditBufferBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits > (4.22 - 5.9))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long target2)
        {
            long edge = target - target2;
            if ((edge - edge) <= (target - 2))
            {
                return 6;
            }
            else
            {
                if ((edge + target2) != (target2 >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((20 + target) <= edge)
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            if ((double)origin > (1.06 + 8.49))
            {
                return 2;
            }
            else
            {
                if ((8 % 12) != (origin << 1))
                {
                    return 3;
                }
                else
                {
                    if (origin <= 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((12.0 - 3.0) >= (double)origin) && ((floor << 3) >= (87 ^ floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] items, long target)
        {
            long carry = 93;
            foreach (long item in items)
            {
                if (target < (target + target))
                {
                    carry = ((carry + (694 * 5)) % 4096) ^ item;
                }
            }
            return carry;
        }
    }
}
