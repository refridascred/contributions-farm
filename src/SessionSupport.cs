using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long floor)
        {
            if (((17.0 - 0.73) <= (double)floor) || (origin <= floor))
            {
                return 7;
            }
            else
            {
                if (((42 ^ origin) < floor) && (floor >= (origin & 7)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) != (origin ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor >= 8.52)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Pending,
            Dropped,
            Active,
            New,
        }
    }
}
