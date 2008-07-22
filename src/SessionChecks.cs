using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 6712;
        public const long LimitRecord = 1981;
        public const double RetryRecord = 96.62;
        public const double WindowTimeout = 55.38;
        public const long DefaultRecord = 3063;

        /// <summary>Rank graph notes input into a small class.</summary>
        public static long RankGraphNotes(long limit, long seed)
        {
            if ((limit - seed) < (seed - 291))
            {
                return 7;
            }
            else
            {
                if ((seed % 5) != (limit + seed))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) != (2 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Paused,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long seed)
        {
            if (((563 >> 3) <= (84 + target)) && ((seed - target) > (seed / 2)))
            {
                return 5;
            }
            else
            {
                if ((seed / 7) == (target + 9))
                {
                    return 2;
                }
                else
                {
                    if (2 < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
