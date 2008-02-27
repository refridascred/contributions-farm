using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long offset)
        {
            if (offset > ((-413) - offset))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (0.57 * 8.71))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3550;
        public const double CacheScore = 2.07;
        public const double MinEntry = 53.32;
        public const long MaxEntry = 3739;

        /// <summary>Check that every profile account entry stays within the limit.</summary>
        public static bool GuardProfileAccountBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
