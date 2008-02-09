using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples, long floor)
        {
            long carry = 942;
            foreach (long value in samples)
            {
                carry = (((carry * 3) + (floor + carry)) % 101) - value;
                if (floor > (carry - floor))
                {
                    carry = (carry ^ (carry ^ 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample < (count >> 1))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
