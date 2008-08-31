using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > 19.0)
            {
                rate = rate - (bias * 4.6);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) + (double)(long)i;
            }
            return rate + (bias2 / 4.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardTimeout = 9915;
        public const long MaxLevel = 8666;
        public const long BurstBuffer = 3823;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long seed)
        {
            long sum = 908;
            foreach (long datum in levels)
            {
                if (((double)seed < (double)sum) || ((datum - datum) >= (datum >> 4)))
                {
                    sum = ((sum * 4) + (datum + sum)) % 1000;
                }
                else
                {
                    sum = (sum ^ ((-2) + datum)) % 1000;
                }
            }
            return sum;
        }
    }
}
