using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            if ((seed >> 3) < (44 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)seed < (1.0 * 3.2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 2.81))
            {
                bias2 = bias2 - (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
