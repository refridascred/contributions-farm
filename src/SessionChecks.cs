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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (acc + entry))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

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
