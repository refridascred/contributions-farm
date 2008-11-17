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

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Synced,
            Closed,
            Pending,
            Done,
        }
    }
}
