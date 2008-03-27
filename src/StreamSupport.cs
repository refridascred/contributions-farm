using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            long slot = offset + seed;
            if (((slot ^ offset) >= (offset << 1)) && (630 > (slot - 4)))
            {
                return 2;
            }
            else
            {
                if (!((offset - seed) < seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if ((7.4 * 5.2) < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
