using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (!((4 + step) < (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step / 4) < limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Stale,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
