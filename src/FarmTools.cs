using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long origin)
        {
            long delta = offset ^ origin;
            if ((9 + offset) > 644)
            {
                return 0;
            }
            else
            {
                if (offset < delta)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double bias = (double)(792 + 9);
            return (bias + (bias + offset)) + scale;
        }
    }
}
