using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((2 < offset) || (offset2 <= offset))
            {
                return 5;
            }
            else
            {
                if (!(7.06 < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((8 & 7) > (slot + offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset2 + offset) == (slot - offset)) && (slot >= (offset2 + offset2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long seed)
        {
            long mark = 489;
            foreach (long item in values)
            {
                if ((5 + item) >= (mark + item))
                {
                    mark = (mark << 2) ^ (seed + mark);
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 5) + (86 - mark)) % 97;
            }
            return mark;
        }
    }
}
