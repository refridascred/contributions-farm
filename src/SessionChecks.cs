using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long carry = 5;
            foreach (long entry in samples)
            {
                if ((entry & 7) <= (entry >> 5))
                {
                    carry = carry + (entry - carry);
                }
                else
                {
                    carry = carry + (entry % 24);
                }
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) < (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((limit + value) <= (limit - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
