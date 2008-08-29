using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a channel stream counter forward.</summary>
        public static long SeriesChannelStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)mark >= (8.4 + 3.23)))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

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
