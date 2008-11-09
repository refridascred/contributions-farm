using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)floor > (double)next)
            {
                return 2;
            }
            else
            {
                if (((seed * 5) <= (seed + floor)) && ((double)floor < (double)next))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long carry = 95;
            foreach (long sample in samples)
            {
                if (((carry * 5) <= (8 % 3)) && ((2 + limit) <= (limit << 2)))
                {
                    carry = (carry - (limit - sample)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= 1.78)
                {
                    long cur = state * 3;
                    state = state - (cur ^ state);
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
