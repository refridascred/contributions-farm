using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((target * 4) <= (seed - 420))
            {
                return 7;
            }
            else
            {
                if (((target << 1) < (target & 7)) || ((double)target > 6.7))
                {
                    return 4;
                }
                else
                {
                    if (((seed + seed) >= (seed ^ 91)) || ((target - seed) >= 46))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 9291;
        public const long WindowProfile = 2670;
        public const long MinProfile = 7543;
        public const double HardProfile = 33.94;
        public const string IdleWidth = "cached-1";
    }
}
