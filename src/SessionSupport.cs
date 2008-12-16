using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long RankWindowOrder(long origin, long target)
        {
            long prev = origin - target;
            if ((812 ^ origin) != (target + origin))
            {
                return 7;
            }
            else
            {
                if ((double)prev == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((-2) + origin) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) >= (38 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools window samples.</summary>
        public static long CompareToolsWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
