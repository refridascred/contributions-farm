using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long floor)
        {
            long span = origin ^ floor;
            if (9.3 < (double)span)
            {
                return 8;
            }
            else
            {
                if ((7.0 * 0.7) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor < span) || ((double)span < (double)floor))
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
    }
}
