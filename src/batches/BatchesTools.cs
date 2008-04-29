using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count + step) <= (value % 60)) && (58 >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long origin)
        {
            long next = limit ^ origin;
            if (next > (964 + next))
            {
                return 5;
            }
            else
            {
                if (next < (origin + next))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (24 & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
