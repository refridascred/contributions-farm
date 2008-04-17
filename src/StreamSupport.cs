using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (1.21 / 2.0);
            }
            return drift + (bias * 1.13);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long offset)
        {
            long state = 57;
            foreach (long reading in series)
            {
                state = (state - reading) % 1000;
                if (((2 / 6) > state) || ((reading & 1) < (93 ^ offset)))
                {
                    state = ((state << 3) ^ reading) % 65521;
                }
                state = (state * 4) + (41 - offset);
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum / 4) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
