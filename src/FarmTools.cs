using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (reading * 5)) % 101) + seed;
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long floor)
        {
            long acc = 53;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (acc + value)) + floor;
            }
            return acc;
        }
    }
}
