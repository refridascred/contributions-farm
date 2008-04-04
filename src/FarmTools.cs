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

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "alpha";
        public const long CacheCounter = 5987;
        public const string HardCounter = "open-v2";
        public const long LimitDepth = 3495;
        public const long BatchDepth = 2010;
    }
}
