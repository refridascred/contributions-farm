using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            New,
            Retry,
            Synced,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
