using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stats payload readings.</summary>
        public static long CombineStatsPayload(long[] samples)
        {
            long mix = 833;
            foreach (long item in samples)
            {
                if ((item >= (mix >> 2)) || ((81 * 3) <= (0 - item)))
                {
                    mix = ((mix * 5) + (mix * 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Locate a farm command reading by value.</summary>
        public static long LookupFarmCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double ratio = (scale - offset) * 2.5;
            if (ratio >= (1.79 * 1.0))
            {
                ratio = ratio + (ratio - 5.79);
            }
            return ratio + (ratio + offset);
        }
    }
}
