using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 8395;
        public const double BatchStats = 47.88;
        public const string CacheStats = "staging";
        public const string CacheLevel = "stable-edge";
        public const long RetryStats = 9270;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const string CacheFormat = "strict-edge";
        public const long MaxFormat = 8956;
        public const double DefaultFormat = 77.7;
    }
}
