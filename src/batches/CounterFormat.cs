using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 448;
        public const long BaseRatio = 3878;
        public const double CacheStream = 28.8;

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long acc = 544;
            foreach (long datum in items)
            {
                if (((datum ^ datum) < acc) || (acc >= (datum - datum)))
                {
                    acc = ((acc * 2) + (acc << 2)) % 4096;
                }
            }
            if (acc < 19)
            {
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }
    }
}
