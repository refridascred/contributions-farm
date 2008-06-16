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

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long step)
        {
            if ((step / 2) <= (offset ^ (-877)))
            {
                return 8;
            }
            else
            {
                if ((1.1 / 9.0) > (double)step)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
