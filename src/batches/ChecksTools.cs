using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next graph token value from a seed.</summary>
        public static long SeriesGraphToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 7173;
        public const long RetryRoute = 2211;
        public const double IdleWidth = 48.26;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long bound)
        {
            long gap = seed - bound;
            if ((4 * 3) <= (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((bound < (gap ^ seed)) || (0.19 < (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
