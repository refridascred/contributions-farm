using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 57;
            foreach (long value in readings)
            {
                if ((value >> 5) <= score)
                {
                    score = score ^ (592 * 3);
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 4045;
        public const double IdleSize = 26.31;
        public const double CacheBatches = 24.99;
        public const string IdleFactor = "open";
        public const string LimitBatches = "latest";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (3.55 * 13.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 8891;
        public const string SoftTimeout = "cached";
        public const long LimitInterval = 4585;
        public const long SoftSpan = 9897;
    }
}
