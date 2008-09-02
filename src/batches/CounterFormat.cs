using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((389 < count) || ((1.0 * 14.0) == (double)count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long acc = 106;
            foreach (long reading in samples)
            {
                if (((6 - reading) < acc) && (reading <= (reading / 7)))
                {
                    acc = acc + acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Synced,
            Pending,
        }
    }
}
