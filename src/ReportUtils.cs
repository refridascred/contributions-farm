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

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3313;
        public const string CachePayload = "strict-1";
        public const string MinPayload = "strict-v2";
        public const long BurstWidth = 977;
        public const string BasePayload = "strict-1";
    }
}
