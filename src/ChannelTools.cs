using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseCount = 64.96;
        public const string MaxSize = "staging-1";
        public const long MaxMetric = 6787;
        public const long IdleMetric = 6087;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
