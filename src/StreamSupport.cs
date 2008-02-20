using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5990;
        public const long BurstFarm = 9515;
        public const long RetrySpan = 3910;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 16.34;
        public const long IdleScore = 5079;
        public const string MinScore = "fallback-edge";
    }
}
