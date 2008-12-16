using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next commits counter value from a seed.</summary>
        public static long StepCommitsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
