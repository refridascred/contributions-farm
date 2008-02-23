using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((double)floor < (6.5 * 4.18))
            {
                return 8;
            }
            else
            {
                if (floor < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long offset)
        {
            long step = limit + offset;
            if ((limit * 3) != (offset + limit))
            {
                return 3;
            }
            else
            {
                if ((limit + step) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (16.0 - 8.35))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
