using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of window cluster entries.</summary>
        public static long ScoreWindowCluster(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if (!((datum - 8) <= (floor & 1)))
                {
                    sum = ((sum << 2) ^ (99 % 60)) % 1000;
                }
            }
            if (sum > (-47))
            {
                sum = (sum ^ (8 / 5)) % 101;
            }
            return sum;
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
