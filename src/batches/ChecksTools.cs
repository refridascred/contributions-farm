using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank context report input into a small class.</summary>
        public static long GradeContextReport(long origin, long origin2)
        {
            if (origin2 >= (origin2 >> 1))
            {
                return 7;
            }
            else
            {
                if (origin2 > (origin2 - origin2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 9680;
        public const long BurstReport = 4805;
        public const long IdleReport = 5183;
        public const long RetryReport = 9049;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 7201;
        public const long BatchRatio = 3415;
        public const double LimitRecord = 70.42;
    }
}
