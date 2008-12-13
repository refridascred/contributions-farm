using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double weight, double floor)
        {
            double rate = floor;
            if (rate >= (weight + 1.0))
            {
                rate = rate - (weight - 8.56);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - weight)) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 7224;
        public const string IdleGraph = "legacy-v2";
        public const long BurstFactor = 151;
        public const double MaxGraph = 60.87;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            long lane = bound ^ seed;
            if ((double)seed > (1.0 * 13.0))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (5.0 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (((double)lane <= (double)5) && ((seed * 3) <= (seed & 15)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
