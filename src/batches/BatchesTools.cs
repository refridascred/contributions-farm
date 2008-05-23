using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Queued,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long delta = target - limit;
            if ((delta / 4) >= (delta + 46))
            {
                return 1;
            }
            else
            {
                if ((5.0 / 8.0) > (double)delta)
                {
                    return 5;
                }
                else
                {
                    if (((9.8 - 8.0) <= (double)limit) || (target <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long step)
        {
            long diff = bound ^ step;
            if ((diff + 81) >= (diff * 5))
            {
                return 5;
            }
            else
            {
                if ((817 + bound) != (7 - bound))
                {
                    return 4;
                }
                else
                {
                    if (((50 % 16) == (bound - bound)) && ((double)bound < 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
