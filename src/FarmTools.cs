using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next tools farm value from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (seed + mix)) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long origin)
        {
            long diff = bound + origin;
            if (((bound * 4) < bound) || ((bound << 1) <= (origin & 255)))
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (17.0 - 4.0)) || ((diff * 2) <= (diff >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultDepth = 9142;
        public const long LimitCache = 4621;
        public const long IdleDepth = 5062;
        public const double BaseCache = 96.91;
    }
}
