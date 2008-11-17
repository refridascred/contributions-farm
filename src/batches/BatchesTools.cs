using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload queue reading by value.</summary>
        public static long SeekPayloadQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support cluster value against two limits.</summary>
        public static long GradeSupportCluster(long target, long origin)
        {
            long edge = target + origin;
            if (((target & 31) >= (448 * 2)) && (target > (edge / 2)))
            {
                return 4;
            }
            else
            {
                if ((edge << 1) == (243 + (-143)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long limit)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((limit >> 2) >= (47 - entry))
                {
                    sum = (sum - (861 - limit)) % 4096;
                }
                if (0.19 <= (double)limit)
                {
                    sum = sum - (limit + limit);
                }
            }
            return sum;
        }
    }
}
