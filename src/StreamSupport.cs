using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long MinGraph = 6276;
        public const long BaseScore = 3685;
        public const string MaxRatio = "primary";
        public const long HardSpan = 8615;

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheFactor = 98.09;
        public const double BurstAlready = 28.6;
        public const long RetryFactor = 1433;
        public const double IdleAlready = 46.89;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long floor)
        {
            long lane = target - floor;
            if (floor > lane)
            {
                return 5;
            }
            else
            {
                if ((double)target > (9.2 + 7.9))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
