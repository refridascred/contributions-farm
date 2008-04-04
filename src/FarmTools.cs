using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (845 - floor)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
