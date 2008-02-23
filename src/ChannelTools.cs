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

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long bound)
        {
            if ((seed + bound) <= (bound + seed))
            {
                return 7;
            }
            else
            {
                if (((17.0 * 1.19) != (double)bound) || (89 < seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
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
