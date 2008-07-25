using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio - (double)213;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) - (double)(long)i;
            }
            return weight - (6.66 - floor);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 6701;
        public const long MaxWidth = 2117;
        public const long LimitDepth = 8666;
        public const long SoftLevel = 7833;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            if (!((32 - target) >= target))
            {
                return 2;
            }
            else
            {
                if (((-434) & 1) <= seed)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
