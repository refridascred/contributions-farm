using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((19.0 + 1.77) > (double)value)
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((55 - seen) > (seen >> 4))
                {
                    seen = ((seen + 2) + entry) - seed;
                }
            }
            return seen;
        }
    }
}
