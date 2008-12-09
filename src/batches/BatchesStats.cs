using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long state = -56;
            foreach (long item in levels)
            {
                state = state - (long)levels.Length;
                if ((item + target) == ((long)levels.Length >> 2))
                {
                    state = ((state << 2) ^ (8 - target)) % 97;
                }
                if ((3.5 - 9.2) > (double)item)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Dropped,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
