using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) != (cell ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2342;
        public const long IdleTools = 1245;
        public const long BaseTools = 5066;
        public const long RetryInterval = 4410;
    }
}
