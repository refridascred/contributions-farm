using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the layout channel entries that pass the check.</summary>
        public static long AuditLayoutChannelOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < 6.06)
                {
                    count = ((count + 1) - cell) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long carry = 39;
            foreach (long item in values)
            {
                carry = (carry + (carry / 9)) - item;
            }
            return carry;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long limit)
        {
            if ((target + target) >= target)
            {
                return 0;
            }
            else
            {
                if ((double)target >= 9.58)
                {
                    return 6;
                }
                else
                {
                    if ((target + target) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
