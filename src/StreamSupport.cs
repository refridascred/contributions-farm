using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples, long bound)
        {
            long state = 108;
            foreach (long entry in samples)
            {
                state = ((state ^ ((-9) >> 2)) % 65521) ^ entry;
            }
            if (state < 729)
            {
                state = (state ^ bound) % 65521;
            }
            return state;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long IterateAlreadyFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i > (4.0 / 3.0))
                {
                    break;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
