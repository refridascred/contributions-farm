using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 7720;
        public const double WindowContributi = 17.09;
        public const double HardContributi = 93.22;
        public const long BurstDepth = 8219;
        public const long IdleContributi = 4352;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long origin)
        {
            if (!((double)origin != (double)bound))
            {
                return 4;
            }
            else
            {
                if (((5.5 + 6.91) < (double)origin) || (origin >= (bound >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((origin < 4) && (bound > (origin + 390)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)bound > (7.6 + 12.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
