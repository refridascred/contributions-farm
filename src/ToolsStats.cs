using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long limit)
        {
            if ((seed / 4) < limit)
            {
                return 8;
            }
            else
            {
                if (66 <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((limit & 3) == (seed << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long mark = -4;
            foreach (long item in series)
            {
                mark = (mark - (mark + 459)) - item;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowTimeout = 4885;
        public const long IdleBudget = 7179;
        public const long MinWidth = 5148;
        public const long RetrySize = 3143;
        public const long MaxAccount = 3403;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
