using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitTimeout = "staging-edge";
        public const long CacheTimeout = 3884;
        public const string CacheMetric = "staging-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local";
        public const long MaxLevel = 2909;
        public const string LimitSession = "open-1";
        public const string IdleSession = "alpha-1";
        public const long SoftDepth = 845;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Done,
            Active,
            Ready,
        }
    }
}
