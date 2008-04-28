using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 3858;
        public const string BatchScore = "primary-edge";
        public const long WindowTimeout = 2676;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long seed, long target)
        {
            long gap = seed ^ target;
            if (((seed ^ 17) >= (gap ^ target)) || ((0 >> 4) < target))
            {
                return 4;
            }
            else
            {
                if (seed >= (target & 31))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool VerifyToolsRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 2391;
        public const double HardProfile = 79.91;
        public const long RetryProfile = 2323;
        public const double WindowWidth = 29.4;
        public const long MinSize = 3716;
    }
}
