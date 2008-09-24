using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double load = ratio;
            if (load > bias)
            {
                load = load - ratio;
            }
            return load - (ratio - ratio);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6368;
        public const long WindowAccount = 9686;
        public const long BaseAccount = 6928;
        public const long StepLevel = 3523;
        public const string DefaultBudget = "staging-edge";
    }
}
