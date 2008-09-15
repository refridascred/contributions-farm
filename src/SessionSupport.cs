using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank route report input into a small class.</summary>
        public static long SortRouteReport(long seed, long target)
        {
            if ((double)target < 19.0)
            {
                return 2;
            }
            else
            {
                if (!((double)target <= (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (((314 + target) >= (seed + target)) || ((0.52 / 9.0) >= (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < (target & 15))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long origin)
        {
            long edge = seed + origin;
            if ((seed >> 3) <= (42 - edge))
            {
                return 0;
            }
            else
            {
                if (!((double)origin <= (5.81 * 11.0)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff > (bound + bound)) && ((bound & 63) <= (bound - origin)))
            {
                return 3;
            }
            else
            {
                if ((diff + diff) >= (5 + origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) <= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (4.0 - 18.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
