using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long target)
        {
            long state = 4;
            foreach (long cell in series)
            {
                state = ((state + (target % 7)) % 4096) ^ cell;
            }
            if (state < 96)
            {
                state = state ^ (target * 5);
            }
            return state;
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
