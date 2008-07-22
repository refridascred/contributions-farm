using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Pending,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Grade a route commits value against two limits.</summary>
        public static long GradeRouteCommits(long step, long step2)
        {
            long prev = step + step2;
            if (((double)step == (double)prev) && ((step2 - prev) < (step2 << 2)))
            {
                return 8;
            }
            else
            {
                if ((step << 2) > prev)
                {
                    return 6;
                }
                else
                {
                    if ((step2 << 3) == (step * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (prev - step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long offset)
        {
            if (floor < (811 + floor))
            {
                return 5;
            }
            else
            {
                if ((floor > (offset & 1)) && ((813 - offset) <= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
