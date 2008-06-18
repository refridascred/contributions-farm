using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Pending,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheCount = 55.1;
        public const string BaseInterval = "staging-v2";
        public const long WindowBatches = 6300;
        public const long RetrySize = 9251;
    }
}
