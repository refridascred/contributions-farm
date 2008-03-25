using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if (!(780 >= (value - value)))
                {
                    carry = ((carry << 2) ^ (carry ^ 88)) % 4096;
                }
            }
            if (carry < 64)
            {
                carry = carry + (carry / 3);
            }
            return carry;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long AuditOrderContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= (-857))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Validate stats session readings against a bound.</summary>
        public static bool ValidateStatsSessionRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
