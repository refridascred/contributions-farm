using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 1692;
        public const string BatchInterval = "standard";
        public const long HardTools = 5260;
        public const long IdleTools = 1191;
        public const double MinSpan = 70.53;

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
