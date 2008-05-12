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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long origin)
        {
            long offset = floor ^ origin;
            if (!((offset ^ offset) <= (floor % 60)))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) <= (origin / 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
