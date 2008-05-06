using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if ((origin & 31) != (58 * 2))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.3 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 8603;
        public const double StepFilter = 83.56;
        public const double CacheInterval = 78.35;
        public const long MinLevel = 7830;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 34.14;
        public const long LimitSpan = 2236;
        public const long SoftCount = 9769;
        public const long CacheEntry = 6518;

        /// <summary>Grade a context session value against two limits.</summary>
        public static long ClassifyContextSession(long floor, long seed)
        {
            if ((floor + (-519)) == (273 + floor))
            {
                return 5;
            }
            else
            {
                if (seed < (11 >> 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
