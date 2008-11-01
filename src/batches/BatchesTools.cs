using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cluster notes pair into a bucket.</summary>
        public static long BucketClusterNotes(long origin, long floor)
        {
            if (!((5.67 * 7.51) == (double)floor))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((origin <= floor) || ((550 >> 3) >= (floor * 5)))
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

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long seed)
        {
            long span = target ^ seed;
            if (((double)span < (0.3 * 4.64)) || ((seed ^ seed) <= (seed % 100)))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= (span - target))
                {
                    return 2;
                }
                else
                {
                    if (span >= (target + 77))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            long prev = limit + offset;
            if ((offset + prev) < (limit & 127))
            {
                return 5;
            }
            else
            {
                if (((limit / 6) != (40 / 5)) || (offset < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((5.4 + 0.4) > (8.37 / 3.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
