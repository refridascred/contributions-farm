using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowLevel = 2124;
        public const double BaseQueue = 56.25;
        public const long StepQueue = 4286;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 644;
        public const double BurstOrder = 89.77;
        public const long DefaultOrder = 1276;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long prev = step - seed;
            if ((3 + 6) < step)
            {
                return 0;
            }
            else
            {
                if ((step + 0) <= prev)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinLevel = 7901;
        public const double LimitTools = 49.47;
        public const string LimitInterval = "strict-1";
    }
}
