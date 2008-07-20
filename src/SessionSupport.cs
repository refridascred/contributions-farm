using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every session token entry stays within the limit.</summary>
        public static bool VerifySessionTokenLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if (((floor - step) == (floor * 3)) && ((floor + 930) >= floor))
            {
                return 6;
            }
            else
            {
                if ((20.0 * 4.83) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long target, long target2)
        {
            long slot = target ^ target2;
            if ((slot % 24) > (slot + target2))
            {
                return 5;
            }
            else
            {
                if ((target & 63) <= (target2 & 1))
                {
                    return 0;
                }
                else
                {
                    if ((3 + target2) != (3 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (slot < (target + target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
