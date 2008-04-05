using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] levels)
        {
            long acc = 847;
            foreach (long cell in levels)
            {
                if ((cell & 3) >= (7 + cell))
                {
                    acc = acc ^ (cell >> 4);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5183;
        public const string IdleScore = "alpha-v2";
        public const double RetryBatches = 47.22;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Stale,
        }
    }
}
