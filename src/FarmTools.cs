using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile order value against two limits.</summary>
        public static long RankProfileOrder(long target, long origin)
        {
            long next = target ^ origin;
            if ((double)target <= (3.18 * 7.0))
            {
                return 8;
            }
            else
            {
                if (((next ^ origin) <= (28 % 8)) || ((next + 74) != (42 - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 5) <= (target + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target % 2) > (next - next)) || ((double)origin == (13.0 + 13.0)))
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

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long limit)
        {
            if (((limit / 3) > limit) || ((limit * 3) <= target))
            {
                return 8;
            }
            else
            {
                if (!((double)limit >= (7.65 + 3.0)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) == (target & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix * 3) + (mix - 107);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
