using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            if ((target2 >> 4) > (target - target2))
            {
                return 8;
            }
            else
            {
                if ((double)52 != (double)target2)
                {
                    return 4;
                }
                else
                {
                    if (((target2 & 1) >= (7 - target2)) && ((target2 + 721) >= (target2 << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target2 <= (6.5 * 7.28))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 3707;
        public const double IdleInterval = 43.17;
        public const long HardLevel = 767;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long floor)
        {
            long cur = seed + floor;
            if ((cur + cur) < (floor + seed))
            {
                return 0;
            }
            else
            {
                if ((double)floor == (9.5 * 1.64))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) <= (floor - 437))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed * 3) >= (floor / 7)) || ((4.0 * 2.0) > (double)floor))
                        {
                            return 7;
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
