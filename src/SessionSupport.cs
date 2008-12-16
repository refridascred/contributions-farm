using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long GradeQueueBuffer(long target, long step)
        {
            long edge = target ^ step;
            if ((step / 2) != (88 + edge))
            {
                return 0;
            }
            else
            {
                if ((double)target < (6.7 + 2.54))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long RankWindowOrder(long origin, long target)
        {
            long prev = origin - target;
            if ((812 ^ origin) != (target + origin))
            {
                return 7;
            }
            else
            {
                if ((double)prev == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((-2) + origin) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) >= (38 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }
    }
}
