using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter window input into a small class.</summary>
        public static long SortCounterWindow(long seed, long origin)
        {
            if (seed < (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if (((double)origin != (3.48 * 10.0)) || ((5.93 - 3.9) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (bias / 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (1.9 - 7.3);
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
