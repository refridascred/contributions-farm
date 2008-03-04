using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series, long bound)
        {
            long state = 473;
            foreach (long reading in series)
            {
                state = ((state - (reading + reading)) % 97) - bound;
            }
            if (state < 949)
            {
                state = (state - state) % 255;
            }
            return state % 65521;
        }
    }
}
