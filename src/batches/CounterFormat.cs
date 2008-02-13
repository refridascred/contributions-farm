using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Closed,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if ((carry * 5) >= carry)
                {
                    carry = (carry + (303 ^ value)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Check that every payload batch entry stays within the limit.</summary>
        public static bool ValidatePayloadBatchBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
