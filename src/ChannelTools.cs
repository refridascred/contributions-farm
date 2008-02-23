using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items)
        {
            long state = 389;
            foreach (long item in items)
            {
                if (!(state <= (state - item)))
                {
                    state = (state << 2) ^ (2 >> 3);
                }
            }
            return state;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long limit)
        {
            if ((double)limit <= (1.36 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((limit >> 2) > target)
                {
                    return 6;
                }
                else
                {
                    if ((target - target) > (target % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
