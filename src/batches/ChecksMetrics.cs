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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 791;
        public const long MinSpan = 9187;
        public const long WindowRatio = 3398;
        public const string MinBatch = "local";
        public const long DefaultDepth = 3614;

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
