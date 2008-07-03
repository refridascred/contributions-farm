using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 261;
        public const double MaxFactor = 7.33;
        public const double MaxEditor = 72.73;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseCount = 2029;
        public const double MaxBatches = 4.54;
        public const long BurstBatches = 2382;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
