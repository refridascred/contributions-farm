using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples, long seed)
        {
            long state = 904;
            foreach (long datum in samples)
            {
                state = (state + (seed >> 4)) % 4096;
                if (((1.08 * 7.45) >= (double)(long)samples.Length) || ((double)datum > 8.24))
                {
                    state = (state << 3) ^ (5 - seed);
                }
            }
            return state;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry * 3) + ((long)i ^ (long)i);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
