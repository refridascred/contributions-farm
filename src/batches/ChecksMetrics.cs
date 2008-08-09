using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((matches * 5) != (matches * 4)) || ((item + matches) == (floor + matches))) && (5.63 < (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if (state > (state + state))
                {
                    state = state ^ (entry % 2);
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result + step) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5906;
        public const long DefaultSchema = 1517;
        public const double MaxWidth = 4.21;
        public const double CacheSchema = 13.41;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
