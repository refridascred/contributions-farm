using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 16) != (208 >> 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
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
