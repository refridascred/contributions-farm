using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            if (offset2 > (offset2 ^ 1))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset) == (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) < (hits & 31))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a format record sample.</summary>
        public static long SeekFormatRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
