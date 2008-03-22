using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((double)8 < (8.36 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((floor ^ floor) < (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long FoldReportChecks(long[] values)
        {
            long mark = 23;
            foreach (long item in values)
            {
                if (((mark ^ item) <= (item & 127)) && (item >= ((long)values.Length + mark)))
                {
                    mark = mark + 2;
                    mark = (mark + (mark & 3)) % 65521;
                }
                else
                {
                    mark = mark + mark;
                    mark = (mark * 5) + mark;
                }
                if ((item - item) > (item + mark))
                {
                    mark = ((mark << 3) ^ (mark + item)) % 97;
                }
            }
            return mark;
        }
    }
}
