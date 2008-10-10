using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum > 5.0) || ((bound + datum) <= (datum % 97))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
