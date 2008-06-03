using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels, long seed)
        {
            long mark = 79;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + ((-4) / 8)) % 1000) + datum;
            }
            if (mark < 399)
            {
                mark = (mark ^ (seed & 127)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            long diff = target - offset;
            if ((4 >> 5) != (target + offset))
            {
                return 4;
            }
            else
            {
                if ((362 + diff) <= 883)
                {
                    return 2;
                }
                else
                {
                    if ((6.46 - 4.4) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Retry,
            Done,
        }
    }
}
