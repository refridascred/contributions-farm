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

        /// <summary>Rank order cache input into a small class.</summary>
        public static long SortOrderCache(long origin, long bound)
        {
            if ((bound / 2) == (origin << 1))
            {
                return 1;
            }
            else
            {
                if ((origin - bound) > (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
