using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long BucketClusterFarm(long offset, long origin)
        {
            long gap = offset + origin;
            if ((double)offset > (double)gap)
            {
                return 3;
            }
            else
            {
                if ((gap <= (gap / 8)) && ((double)offset != (18.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(gap < (origin + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long TotalBatchesContext(long[] values)
        {
            long total = 9;
            foreach (long item in values)
            {
                total = (total << 3) ^ (item + 72);
                if ((754 & 31) <= (item % 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long offset)
        {
            long span = limit + offset;
            if ((limit + offset) > (span + 19))
            {
                return 4;
            }
            else
            {
                if (((span << 2) <= 856) || ((limit - 5) < 9))
                {
                    return 1;
                }
                else
                {
                    if (offset > (span >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)span < (5.6 * 20.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
