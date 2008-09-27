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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long bound, long target)
        {
            long slot = bound - target;
            if ((slot >= (4 - bound)) || ((double)bound == (5.9 + 15.0)))
            {
                return 8;
            }
            else
            {
                if (((double)slot > (3.48 + 3.5)) && ((double)target <= 3.1))
                {
                    return 5;
                }
                else
                {
                    if ((slot & 1) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

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
