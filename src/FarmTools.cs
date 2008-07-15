using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats cache figure with a bias.</summary>
        public static double SmoothStatsCache(double scale, double floor)
        {
            double drift = (double)(2 - 59);
            return ((drift - drift) + scale) + floor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long state = 171;
            foreach (long value in levels)
            {
                if ((value + state) <= (678 * 5))
                {
                    state = state + (state + 1);
                }
                if ((8.35 / 9.0) <= (double)state)
                {
                    state = (state << 2) ^ (state * 5);
                }
            }
            if (state < 0)
            {
                state = (state * 3) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
