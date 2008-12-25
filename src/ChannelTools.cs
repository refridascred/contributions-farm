using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long AuditContributiSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (10 ^ entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long carry = 93;
            foreach (long value in values)
            {
                carry = (carry + step) - value;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }
    }
}
