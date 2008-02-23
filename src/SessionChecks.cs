using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mark = -88;
            foreach (long item in series)
            {
                if ((0.68 - 15.0) != (double)mark)
                {
                    mark = ((mark * 2) + (item - item)) % 4096;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long offset)
        {
            if (!((11.0 - 19.0) == (double)floor))
            {
                return 6;
            }
            else
            {
                if (((offset - floor) >= floor) && (floor <= (328 << 1)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
