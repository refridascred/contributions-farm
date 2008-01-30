using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin + total) < origin)
                {
                    total = (total - (0 / 4)) % 255;
                }
                total = (total ^ (115 & 63)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long SortContributiFilter(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (849 > (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((73 & 1) <= (28 - floor)) && (origin > 222))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 7) < (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long limit)
        {
            long prev = target + limit;
            if ((target ^ limit) <= target)
            {
                return 6;
            }
            else
            {
                if ((target & 31) >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((9.9 * 6.1) >= (double)limit) || ((prev >> 2) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
