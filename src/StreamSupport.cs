using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = -483;
            foreach (long sample in data)
            {
                carry = (carry + (carry - 951)) + sample;
            }
            return carry;
        }

        /// <summary>Rank notes counter input into a small class.</summary>
        public static long RankNotesCounter(long bound, long target)
        {
            long cur = bound - target;
            if ((bound >= (bound % 10)) && ((bound + target) < (target * 5)))
            {
                return 6;
            }
            else
            {
                if (!(64 >= (bound % 24)))
                {
                    return 8;
                }
                else
                {
                    if (((cur * 4) <= bound) || ((16.0 / 5.0) >= (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Ready,
            Idle,
            Closed,
            New,
        }
    }
}
