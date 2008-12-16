using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 1358;
        public const string MinRoute = "latest-edge";
        public const string CacheRoute = "open-1";
        public const long SoftInterval = 3860;
        public const string LimitScore = "latest-1";

        /// <summary>Define report limits and defaults.</summary>
        public const string StepFactor = "fallback";
        public const string HardFactor = "fallback-1";
        public const double CacheSize = 40.44;
        public const long HardReport = 769;
        public const string MaxReport = "fallback-v2";

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mark = 954;
            foreach (long reading in levels)
            {
                mark = ((mark + (mark - 78)) % 101) + reading;
            }
            return mark;
        }
    }
}
