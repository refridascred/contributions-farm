using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + 561) != (value % 7))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats order value against two limits.</summary>
        public static long GradeStatsOrder(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((floor * 3) >= floor)
            {
                return 1;
            }
            else
            {
                if ((205 / 3) <= (diff * 2))
                {
                    return 7;
                }
                else
                {
                    if (((floor - floor) == (floor + 939)) || ((6 * 2) > (floor2 - floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool CheckGraphMetricsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
