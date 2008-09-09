using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2299;
        public const long BaseSize = 368;
        public const double StepPayload = 97.1;
        public const string BatchPayload = "strict-v2";
        public const string SoftPayload = "staging-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 95.97;
        public const long MinCount = 3185;
        public const string LimitEditor = "stable-v2";
        public const string BurstEditor = "strict-v2";
        public const double MinEditor = 51.11;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Active,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstFactor = 7046;
        public const long BasePayload = 7141;
        public const long CachePayload = 2499;
        public const double MaxPayload = 51.22;
    }
}
