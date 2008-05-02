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

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long FindChecksChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const string CacheFormat = "strict-edge";
        public const long MaxFormat = 8956;
        public const double DefaultFormat = 77.7;
    }
}
