using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] readings, long target)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                acc = (acc << 2) ^ (sample + target);
            }
            if (acc > 37)
            {
                acc = ((acc << 3) ^ (target >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSpan = 1094;
        public const long MinCommand = 7556;
        public const long BaseSize = 213;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8178;
        public const string MaxLevel = "strict";
        public const string WindowFactor = "open";
        public const double RetryGraph = 72.06;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double drift = bias;
            if (drift < (bias * 9.28))
            {
                drift = (drift + (bias + drift)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (7.89 + drift);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits - hits)) && ((cell / 7) > (8 + cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
