using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Pending,
            New,
            Idle,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long floor2)
        {
            if (((floor2 ^ 864) != (floor2 - floor2)) && (floor2 >= 5))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) >= (1 / 6))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (floor >> 4))
                    {
                        return 0;
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
