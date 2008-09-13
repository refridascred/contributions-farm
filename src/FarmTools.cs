using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support session value from a seed.</summary>
        public static long RollSupportSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (anchor * 2)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 82.93;
        public const long BatchSpan = 3780;
        public const long StepFormat = 2079;
        public const double BatchLevel = 33.14;
        public const long IdleLevel = 9122;
    }
}
