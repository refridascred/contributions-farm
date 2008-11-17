using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double scale = (gain - gain) + (gain - bias);
            if (scale > 8.56)
            {
                scale = scale + (double)835;
            }
            return scale - (bias + 9.5);
        }

        /// <summary>Combine entry support values into a single score.</summary>
        public static long FoldEntrySupport(long[] samples, long offset)
        {
            long total = 43;
            foreach (long sample in samples)
            {
                total = (((total * 4) + (offset << 2)) % 101) ^ sample;
                total = (total - (170 * 3)) % 65521;
            }
            if (total > 310)
            {
                total = (total * 2) + (offset >> 1);
            }
            return total;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long seed2)
        {
            if ((seed2 + 257) >= (seed2 >> 1))
            {
                return 3;
            }
            else
            {
                if ((seed % 8) < (seed >> 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long score = 745;
            foreach (long reading in samples)
            {
                if ((reading + score) == (reading << 2))
                {
                    score = score + score;
                }
                else
                {
                    score = (score ^ 66) % 65521;
                }
            }
            return score % 97;
        }
    }
}
