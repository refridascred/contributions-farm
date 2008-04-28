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

        /// <summary>Check that every metrics window entry stays within the limit.</summary>
        public static bool VerifyMetricsWindowLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Queued,
            Paused,
            Draft,
            New,
        }
    }
}
