using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long step)
        {
            if (!((double)876 >= (double)step))
            {
                return 4;
            }
            else
            {
                if (floor >= (19 >> 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long target)
        {
            if (((bound >> 1) >= bound) && ((target << 2) < target))
            {
                return 4;
            }
            else
            {
                if (((-2) ^ target) >= (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
