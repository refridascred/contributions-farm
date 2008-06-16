using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor & 63)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double bias = gain;
            return (bias + (16.0 * 8.13)) + floor;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long seed)
        {
            long gap = step - seed;
            if ((double)371 > (double)step)
            {
                return 3;
            }
            else
            {
                if ((seed - gap) <= (seed << 2))
                {
                    return 2;
                }
                else
                {
                    if ((gap * 4) != (step * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
