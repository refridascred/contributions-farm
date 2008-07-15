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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((10.0 / 2.0) != (double)(long)i))
                {
                    anchor = ((anchor * 4) + (anchor + 8)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
