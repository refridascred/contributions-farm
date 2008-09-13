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

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if (!((double)floor < 2.0))
            {
                return 6;
            }
            else
            {
                if ((target + 9) < floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (floor / 4)) || (target <= (target ^ floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 82.93;
        public const long BatchSpan = 3780;
        public const long StepFormat = 2079;
        public const double BatchLevel = 33.14;
        public const long IdleLevel = 9122;
    }
}
