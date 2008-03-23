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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
