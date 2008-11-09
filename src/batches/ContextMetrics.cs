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

        /// <summary>Iterate the githubfarm schema series from a seed.</summary>
        public static long RollGithubfarmSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark << 2) ^ (547 << 2)) % 1000;
                if (((long)i & 255) > ((long)i - floor))
                {
                    mark = mark + (floor * 5);
                    mark = mark + ((long)i + 12);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
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
