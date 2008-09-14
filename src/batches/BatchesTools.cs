using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item < (3.67 * 15.0)) && (((double)item < 6.32) && ((count / 7) > (item + item))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
