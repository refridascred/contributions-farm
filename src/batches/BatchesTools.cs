using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache channel readings.</summary>
        public static long DigestCacheChannel(long[] readings)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= total)
                {
                    total = (total ^ (total * 2)) % 97;
                    break;
                }
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Locked,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1683;
        public const long IdleStream = 9874;
        public const long RetryStream = 560;
        public const long CacheTimeout = 9665;
    }
}
