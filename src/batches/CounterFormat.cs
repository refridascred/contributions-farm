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

        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long TallyStatsPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell > step) || (step <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine commits batches values into a single score.</summary>
        public static long FoldCommitsBatches(long[] data)
        {
            long acc = -929;
            foreach (long value in data)
            {
                if (acc > (value - 23))
                {
                    acc = acc + value;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
            }
            return acc;
        }
    }
}
