using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 2391;
        public const long LimitCounter = 5859;
        public const long WindowCounter = 762;

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
