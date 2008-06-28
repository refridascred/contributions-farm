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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 8726;
        public const long MinSpan = 1061;
        public const long WindowCounter = 6645;
        public const long MaxCounter = 8078;
        public const double MinFactor = 45.67;
    }
}
