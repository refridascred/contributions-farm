using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a profile checks figure with a bias.</summary>
        public static double AdjustProfileChecks(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = (ratio - (double)914) + rate;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)209) + (double)(long)i;
            }
            return ratio - (double)580;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double scale = (double)((-21) / 5);
            if (scale >= (scale + bias))
            {
                scale = (scale - scale) - weight;
            }
            return scale - scale;
        }
    }
}
