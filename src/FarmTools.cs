using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryLevel = 3.49;
        public const double LimitBudget = 54.46;
        public const long BaseContext = 285;
        public const long BatchRatio = 3766;
        public const long BatchContext = 5049;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long SeriesCommitsBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                long prev = mix + (mix / 9);
                if ((offset * 3) > 70)
                {
                    break;
                }
                if (!(prev < (2 >> 1)))
                {
                    mix = (mix + (long)i) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
