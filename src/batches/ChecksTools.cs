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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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
