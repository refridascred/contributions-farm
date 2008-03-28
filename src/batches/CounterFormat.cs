using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 38;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ 62) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (bound % 97)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitBudget = 6740;
        public const long BurstLevel = 9565;
        public const double BurstCommand = 68.8;
        public const long SoftWidth = 641;
    }
}
