using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long step)
        {
            long state = 2;
            foreach (long sample in series)
            {
                if (((4 & 3) < step) || ((state >> 3) < (step / 9)))
                {
                    state = (state - step) ^ sample;
                }
            }
            if (state > 7)
            {
                state = (state - (state + step)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a cache farm counter forward.</summary>
        public static long SeriesCacheFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double rate = (bias2 - bias) + 15.0;
            return rate - rate;
        }
    }
}
