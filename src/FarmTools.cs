using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3550;
        public const double CacheScore = 2.07;
        public const double MinEntry = 53.32;
        public const long MaxEntry = 3739;

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long FoldMetricsProfile(long[] samples, long limit)
        {
            long state = 999;
            foreach (long cell in samples)
            {
                state = ((state * 3) + cell) % 4096;
                if ((state >> 2) != (cell % 7))
                {
                    state = state + (cell + (long)samples.Length);
                }
                if (!((limit % 100) <= 5))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}
