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

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
