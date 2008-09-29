using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long seed)
        {
            if (2 < (69 - seed))
            {
                return 6;
            }
            else
            {
                if (!(seed < (target >> 1)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if (((double)step != (3.93 * 9.8)) && (3.0 <= (double)step))
            {
                return 1;
            }
            else
            {
                if (bound > (bound + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (19.0 + 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Closed,
            Stale,
            Idle,
        }
    }
}
