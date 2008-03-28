using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4716;
        public const long MinLayout = 4836;
        public const string CacheLayout = "staging-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 47.29;
        public const long LimitStream = 1532;
        public const long BatchStream = 7224;
        public const string CacheStream = "cached-v2";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
