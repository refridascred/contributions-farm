using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if (!(origin <= (offset + origin)))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= 2.78)
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long bound)
        {
            if (((limit - limit) > (675 + bound)) || (limit < (bound ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((double)limit == (8.3 + 7.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
