using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 65.16;
        public const double HardScore = 53.35;
        public const long DefaultContext = 9719;

        /// <summary>Grade a session order value against two limits.</summary>
        public static long SortSessionOrder(long origin, long floor)
        {
            if (!((floor + origin) != (origin - origin)))
            {
                return 2;
            }
            else
            {
                if (!((double)origin <= (1.1 + 17.0)))
                {
                    return 3;
                }
                else
                {
                    if (((floor + floor) >= (16 ^ origin)) && ((floor - 281) < (384 ^ floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.1 * 10.0) >= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile support series from a seed.</summary>
        public static long IterateProfileSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i >> 3) <= (1 + (long)i))
                {
                    mix = (mix ^ ((long)i - target)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
