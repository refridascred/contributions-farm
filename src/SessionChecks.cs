using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            long diff = limit + step;
            if ((diff - 892) < (limit + (-37)))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 4.3) == (double)diff)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                state = (state - (item * 5)) % 101;
            }
            return state;
        }

        /// <summary>Grade a payload schema value against two limits.</summary>
        public static long SortPayloadSchema(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((7 % 16) != (bound << 1))
            {
                return 6;
            }
            else
            {
                if (!((double)bound2 <= 0.41))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
