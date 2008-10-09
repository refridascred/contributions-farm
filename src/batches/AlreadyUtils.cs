using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double scale = 4.29 + 4.45;
            if (scale <= (double)110)
            {
                scale = ((scale - (double)36) - rate) + offset;
            }
            else
            {
                scale = scale + (double)4;
            }
            return scale + (8.24 - 11.0);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 - scale) + (double)(long)i) - floor;
            }
            return scale2 - (scale + scale);
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double gain = offset;
            if (gain >= weight)
            {
                gain = gain + 9.1;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
