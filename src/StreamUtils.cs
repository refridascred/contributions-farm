using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            New,
            Ready,
            Paused,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Ready,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.64 * 5.8) >= (double)limit)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
