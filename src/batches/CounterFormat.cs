using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((offset >= (hits + cell)) || (offset > (-90))) || ((cell - hits) >= 51))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            long offset = bound - limit;
            if ((3 - 28) < offset)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (3.0 - 19.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
