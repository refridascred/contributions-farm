using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 476;
        public const long BurstSpan = 537;
        public const double HardToken = 28.76;
        public const string MinSize = "cached-1";
        public const double BurstToken = 6.72;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Retry,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSpan = "strict-edge";
        public const long MinEntry = 4785;
        public const double StepEntry = 30.87;
        public const string StepCount = "local-1";
    }
}
