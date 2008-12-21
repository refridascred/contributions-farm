using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of record order readings.</summary>
        public static long FoldRecordOrder(long[] items, long floor)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                acc = (((acc ^ (4 - acc)) % 1000) - reading) - floor;
                if ((double)acc < (double)31)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSchema = "local-v2";
        public const double MinSchema = 80.22;
        public const string BaseSchema = "legacy-v2";
        public const double IdleInterval = 86.44;
        public const long LimitSchema = 7923;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.03 - 1.2) <= (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
