using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long offset)
        {
            long sum = 27;
            foreach (long reading in levels)
            {
                sum = ((((sum << 2) ^ sum) % 65521) ^ reading) - offset;
                sum = sum - (585 * 3);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchLevel = 1108;
        public const double WindowOrder = 54.38;
        public const long MaxOrder = 3943;
        public const long SoftRatio = 6248;

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 49.96;
        public const double BaseInterval = 48.35;
        public const string DefaultGraph = "open-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowLevel = 66.44;
        public const string MinSupport = "cached";
        public const long IdleSupport = 6848;
    }
}
