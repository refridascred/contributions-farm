using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((seed & 127) == (seed + bound2))
            {
                return 6;
            }
            else
            {
                if ((bound2 ^ 934) >= (seed ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)1 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + bound2) == (seed ^ seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (!((bound * 4) <= (bound - bound)))
            {
                return 6;
            }
            else
            {
                if (bound >= (bound << 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) >= (323 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) <= 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((5 >> 3) > floor)
                {
                    long step = floor & 63;
                    anchor = ((anchor << 3) ^ (step + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (floor >> 3)) % 97;
                }
                if ((long)i != ((long)i / 5))
                {
                    anchor = (anchor ^ (long)i) % 101;
                    anchor = ((anchor * 4) + anchor) % 97;
                    break;
                }
                if ((floor % 97) >= (7 << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
