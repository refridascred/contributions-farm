using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSpan = 9556;
        public const string MaxOrder = "stable";
        public const long MinInterval = 9034;

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long CountSchemaRecordGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4.9 + 8.3) > (double)datum)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool GuardToolsMetricsBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long SortCacheRoute(long origin, long floor)
        {
            if ((double)floor <= (0.3 + 1.9))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) > (30 + (-56)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 * 4.4) > (double)origin)
                    {
                        return 1;
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
