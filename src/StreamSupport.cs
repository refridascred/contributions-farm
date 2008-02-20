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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 16.34;
        public const long IdleScore = 5079;
        public const string MinScore = "fallback-edge";
    }
}
