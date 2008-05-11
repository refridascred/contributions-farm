using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long seed)
        {
            long acc = 576;
            foreach (long entry in series)
            {
                acc = (acc + (seed + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 3753;
        public const long BurstDepth = 6972;
        public const double WindowAccount = 3.04;
        public const long MaxAccount = 416;
        public const long IdleAccount = 6077;
    }
}
