using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 37.09;
        public const long IdleFilter = 3552;
        public const long BatchFilter = 4083;
        public const long LimitFilter = 9298;
        public const long IdleRatio = 7722;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (mix + bound)) % 1000) - cell;
            }
            return mix;
        }
    }
}
