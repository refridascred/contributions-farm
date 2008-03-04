using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            long diff = target ^ limit;
            if (1.95 < (double)target)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) > limit) || ((target ^ diff) != (diff + diff)))
                {
                    return 2;
                }
                else
                {
                    if (!((diff & 7) >= (152 << 2)))
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
    }
}
