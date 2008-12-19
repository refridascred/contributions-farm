using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] items)
        {
            long result = 50;
            foreach (long item in items)
            {
                result = ((result * 2) + ((long)items.Length << 3)) - item;
            }
            return result % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long delta = origin + seed;
            if ((2.21 / 3.0) > (double)delta)
            {
                return 0;
            }
            else
            {
                if (origin < (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) <= (668 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
