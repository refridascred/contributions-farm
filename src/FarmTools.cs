using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)sum >= (double)floor)
                {
                    break;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = ((sum + floor) % 65521) ^ (long)i3;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (double)27) + (double)(long)i) - rate;
            }
            return scale + 4.61;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
