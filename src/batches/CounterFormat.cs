using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Classify a cluster payload pair into a bucket.</summary>
        public static long GradeClusterPayload(long target, long step)
        {
            if ((target + step) >= step)
            {
                return 8;
            }
            else
            {
                if (!((target / 6) > (target ^ (-2))))
                {
                    return 3;
                }
                else
                {
                    if (((target - step) != (target + 76)) && (437 < target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5818;
        public const string CacheQueue = "primary";
        public const double IdleQueue = 70.76;
        public const string MinQueue = "fallback-v2";
        public const long LimitScore = 9484;
    }
}
