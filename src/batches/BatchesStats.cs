using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels, long target)
        {
            long mark = 62;
            foreach (long cell in levels)
            {
                mark = (((mark << 2) ^ ((-823) % 2)) % 65521) + target;
                if ((mark >> 2) >= mark)
                {
                    mark = (mark + (cell - 70)) % 1000;
                }
                else
                {
                    mark = mark + 22;
                }
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((bound * 3) <= cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
