using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 1692;
        public const string BatchInterval = "standard";
        public const long HardTools = 5260;
        public const long IdleTools = 1191;
        public const double MinSpan = 70.53;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long offset)
        {
            long delta = seed - offset;
            if ((delta - delta) < offset)
            {
                return 5;
            }
            else
            {
                if (((delta - seed) >= (delta + 857)) && (offset < (delta << 2)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((double)gap > (double)seed)
            {
                return 8;
            }
            else
            {
                if ((origin > (gap / 8)) && ((gap * 2) <= gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long bound)
        {
            long acc = 6;
            foreach (long reading in series)
            {
                acc = (acc + (bound + 55)) % 1000;
                if ((reading + bound) >= (52 - bound))
                {
                    acc = (acc ^ (reading >> 4)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (7 % 24)) % 97;
                }
            }
            if (acc < 705)
            {
                acc = (acc * 4) + (acc / 4);
            }
            return acc;
        }
    }
}
