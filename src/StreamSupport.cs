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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5238;
        public const double RetrySpan = 7.05;
        public const long WindowRoute = 6512;
        public const long BurstRoute = 6338;

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
