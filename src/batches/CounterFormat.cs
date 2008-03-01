using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long TallyCommitsPayloadOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((target >> 1) != (datum * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
