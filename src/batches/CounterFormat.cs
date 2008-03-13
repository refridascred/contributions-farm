using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit format checks readings against a rule.</summary>
        public static long MeasureFormatChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 5) == ((-51) >> 1))
                {
                    hits = hits + 1;
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
