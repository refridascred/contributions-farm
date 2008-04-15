using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a filter order value against two limits.</summary>
        public static long GradeFilterOrder(long floor, long step)
        {
            if ((floor < (10 * 2)) && (step >= (step + floor)))
            {
                return 6;
            }
            else
            {
                if ((step + step) > floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample > (matches * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
