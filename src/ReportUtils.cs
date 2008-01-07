using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long limit)
        {
            long step = seed + limit;
            if (seed >= (seed >> 2))
            {
                return 2;
            }
            else
            {
                if ((step & 255) < 8)
                {
                    return 1;
                }
                else
                {
                    if ((2.96 + 1.1) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 / 7.0) > (double)limit)
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

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long seed)
        {
            long delta = step + seed;
            if ((delta + seed) > seed)
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= (delta << 3))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 7.6) <= (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long SeriesContextLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if (((587 - step) <= (result / 4)) && ((double)result == (6.0 / 9.0)))
                {
                    result = (result << 2) ^ (299 / 7);
                    break;
                }
                else
                {
                    result = (result * 5) + ((long)i + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every payload support entry stays within the limit.</summary>
        public static bool CheckPayloadSupportLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Failed,
            Dropped,
            Active,
            New,
        }
    }
}
