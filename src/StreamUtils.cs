using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepScore = "standard-1";
        public const string CacheRatio = "alpha";
        public const long BaseCommits = 941;
        public const string SoftCommits = "latest-v2";

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if ((783 - anchor) != (cell & 15))
                {
                    anchor = anchor + 2;
                }
                if ((cell / 8) <= (long)samples.Length)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series, long offset)
        {
            long sum = 900;
            foreach (long item in series)
            {
                if ((item << 1) < offset)
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
