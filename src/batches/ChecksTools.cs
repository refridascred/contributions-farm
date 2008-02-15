using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)state > (8.3 - 8.3)))
                {
                    state = ((state << 3) ^ (state - (long)i)) % 4096;
                }
                else
                {
                    state = (state - offset) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 5.9)
            {
                drift = drift + (bias + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Fold a list of channel format readings.</summary>
        public static long FoldChannelFormat(long[] levels, long origin)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (total + 63);
                if ((948 ^ origin) == (sample + (long)levels.Length))
                {
                    break;
                }
                else
                {
                    total = ((total << 3) ^ origin) % 65521;
                }
                if ((3.9 + 13.0) == (double)origin)
                {
                    total = (total - (total - 296)) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ (636 % 24)) % 1000;
            }
            return total;
        }

        /// <summary>Validate stats order readings against a bound.</summary>
        public static bool GuardStatsOrderBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
