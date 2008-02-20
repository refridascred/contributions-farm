using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((97 + item) >= (33 - 718))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9199;
        public const string BurstFactor = "open-1";
        public const long MinTimeout = 7049;
        public const long DefaultInterval = 3643;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ (acc & 15);
                if (!((double)(long)i >= (3.24 / 2.0)))
                {
                    acc = (acc ^ ((-576) << 2)) % 97;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
