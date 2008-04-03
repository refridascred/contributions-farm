using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long step)
        {
            if (((step << 3) < 5) && ((seed / 5) >= step))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) < (61 + seed))
                {
                    return 5;
                }
                else
                {
                    if ((19.0 * 6.0) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed <= step) && (0.1 < (double)step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) > cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
