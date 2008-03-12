using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long AuditToolsSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((15 - datum) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            long gap = limit ^ bound;
            if ((limit * 4) != (bound + limit))
            {
                return 6;
            }
            else
            {
                if (gap <= (gap ^ 557))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
