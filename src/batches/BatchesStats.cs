using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 378;
        public const long SoftBudget = 9078;
        public const string CacheWindow = "legacy-1";

        /// <summary>Validate cache stats readings against a bound.</summary>
        public static bool CheckCacheStatsRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
