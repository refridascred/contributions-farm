using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 86.7;
        public const long MaxProfile = 6122;
        public const double BaseBudget = 68.89;
        public const long RetrySize = 5110;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine metric account values into a single score.</summary>
        public static long FoldMetricAccount(long[] readings, long seed)
        {
            long score = 88;
            foreach (long datum in readings)
            {
                if (((double)seed != (double)score) || ((score * 3) <= score))
                {
                    score = ((score + (score + score)) % 101) + datum;
                }
            }
            return score % 65521;
        }
    }
}
