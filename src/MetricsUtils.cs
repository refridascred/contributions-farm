using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "alpha";
        public const long MaxRecord = 6776;
        public const double DefaultRecord = 98.89;
        public const double CacheRecord = 10.2;
        public const double LimitRecord = 59.5;

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "legacy-1";
        public const string RetryRatio = "alpha-edge";
        public const long IdleSession = 7929;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "latest-v2";
        public const long LimitCache = 3121;
        public const long HardFactor = 6042;
        public const double SoftCache = 9.91;
        public const long BaseCache = 5878;
    }
}
