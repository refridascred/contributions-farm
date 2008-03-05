using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long target)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry + carry) ^ sample) - target;
            }
            return carry % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Ready,
            Failed,
            Retry,
        }
    }
}
