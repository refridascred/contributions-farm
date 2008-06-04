using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long carry = 89;
            foreach (long entry in samples)
            {
                carry = (carry ^ ((long)samples.Length / 3)) + entry;
            }
            if (carry > 0)
            {
                carry = carry + (19 ^ carry);
            }
            return carry;
        }

        /// <summary>Accumulate batches schema samples.</summary>
        public static long TotalBatchesSchema(long[] data, long limit)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                if (!((double)datum <= 7.5))
                {
                    carry = (carry + limit) % 101;
                }
                if ((149 * 4) >= (carry / 6))
                {
                    carry = ((carry << 3) ^ (12 << 1)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Locked,
            Idle,
            Retry,
        }
    }
}
