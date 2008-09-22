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

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long CompareEditorFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
