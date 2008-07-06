using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((offset + datum) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long bound)
        {
            if (!(seed <= bound))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 5.3)
                {
                    return 8;
                }
                else
                {
                    if (((seed + 36) <= seed) || ((2 + 382) >= (8 + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound ^ bound) <= (bound + 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
