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

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long floor)
        {
            long result = 1;
            foreach (long value in levels)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result ^ (long)levels.Length) ^ (long)i2;
                }
                if ((double)floor < (5.5 / 5.0))
                {
                    result = (result - (result / 4)) % 255;
                }
                else
                {
                    result = ((result * 2) + value) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
