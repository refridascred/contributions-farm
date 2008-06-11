using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (bias + bias2) / 3.0;
            if (weight < (bias / 2.0))
            {
                weight = weight + (double)(-925);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)8;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (state / 2)) % 65521;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
