using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 7.34;
        public const long CacheRatio = 8985;
        public const long StepLayout = 2293;

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long seed)
        {
            long gap = target + seed;
            if (((6.0 - 3.6) < (double)target) && ((double)target == (7.8 / 7.0)))
            {
                return 5;
            }
            else
            {
                if ((gap * 3) < target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepInterval = "stable-edge";
        public const long CacheSpan = 3412;
        public const string MinDepth = "latest-1";
        public const long SoftLevel = 2898;
    }
}
