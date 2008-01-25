using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLevel = "stable-v2";
        public const string BatchRatio = "primary-edge";
        public const long BurstRatio = 8454;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
