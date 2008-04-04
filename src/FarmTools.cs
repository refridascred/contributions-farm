using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every graph entry entry stays within the limit.</summary>
        public static bool CheckGraphEntryRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double mean = (double)(44 + 989);
            if (mean <= (double)19)
            {
                mean = mean - offset;
            }
            return mean + (weight * 7.3);
        }
    }
}
