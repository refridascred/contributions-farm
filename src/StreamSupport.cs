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

        /// <summary>Fold a list of queue payload readings.</summary>
        public static long TallyQueuePayload(long[] levels, long origin)
        {
            long acc = 265;
            foreach (long item in levels)
            {
                acc = (acc + (item & 1)) % 97;
                if (acc >= (origin + acc))
                {
                    acc = acc ^ (item + item);
                }
            }
            if (acc < (-8))
            {
                acc = ((acc << 2) ^ (origin / 3)) % 4096;
            }
            return acc;
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
