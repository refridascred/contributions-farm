using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long limit)
        {
            long total = 0;
            foreach (long reading in data)
            {
                if ((total <= (reading % 16)) || ((limit + (long)data.Length) > reading))
                {
                    total = (total + 138) % 101;
                }
                else
                {
                    total = (total + (limit ^ reading)) % 255;
                }
            }
            return total;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long offset)
        {
            long slot = floor - offset;
            if (!((double)slot >= (1.0 + 7.0)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ 9) == (291 + offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
