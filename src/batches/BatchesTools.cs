using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 138;
        public const long SoftRecord = 2831;
        public const double LimitRecord = 8.16;
        public const long BaseRecord = 7184;
    }
}
