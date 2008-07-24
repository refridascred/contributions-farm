using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ limit) == (limit % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values)
        {
            long carry = 55;
            foreach (long value in values)
            {
                if ((value + carry) <= (carry + 70))
                {
                    carry = carry ^ carry;
                }
                carry = (carry - value) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next channel batch value from a seed.</summary>
        public static long StepChannelBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
