using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a commits window value against two limits.</summary>
        public static long RankCommitsWindow(long target, long seed)
        {
            if (((13.0 * 5.2) != (double)target) && ((seed & 1) != (target + 4)))
            {
                return 0;
            }
            else
            {
                if ((14 * 4) <= (target & 255))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long limit)
        {
            if (!(limit < (limit - floor)))
            {
                return 1;
            }
            else
            {
                if (76 > floor)
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) > limit) || ((floor << 1) != (24 - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor << 2) > (limit * 4)) || (limit < (limit % 24)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 7454;
        public const long CacheInterval = 7883;
        public const long HardStream = 6872;
        public const long MaxTimeout = 7642;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
