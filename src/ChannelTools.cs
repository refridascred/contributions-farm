using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long target)
        {
            if ((double)(-154) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)target > 8.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long offset)
        {
            long edge = seed - offset;
            if (!((9.29 * 3.9) > (double)edge))
            {
                return 1;
            }
            else
            {
                if ((483 + 631) < (edge & 127))
                {
                    return 6;
                }
                else
                {
                    if ((edge + seed) == (seed + 44))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Stale,
            Idle,
        }
    }
}
