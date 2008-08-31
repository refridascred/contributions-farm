using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 2172;
        public const double WindowFactor = 13.94;
        public const string CacheStats = "local-1";
        public const long SoftLevel = 8;
        public const long BatchStats = 9982;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long diff = step - seed;
            if ((364 << 2) <= seed)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (85 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((diff & 7) <= (diff * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
