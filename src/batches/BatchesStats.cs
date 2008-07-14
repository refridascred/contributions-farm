using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 5) + (seed + 2)) % 1000) - (long)i2;
                    mark = (mark + (mark >> 1)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.77;
        public const double HardWindow = 55.56;
        public const long BatchDepth = 4724;
        public const double DefaultWindow = 55.05;
        public const long BurstWindow = 9244;
    }
}
