using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 1088;
        public const long HardWidth = 9953;
        public const long DefaultBatch = 842;
        public const long BaseSize = 6646;
        public const long IdleRatio = 3415;

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long bound)
        {
            long score = 353;
            foreach (long entry in series)
            {
                score = (((score - (269 & 63)) % 255) - entry) - bound;
            }
            return score;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Dropped,
            Synced,
        }
    }
}
