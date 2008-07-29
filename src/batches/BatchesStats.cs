using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long TallyCacheOrderMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (46 > cell)
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseRatio = "standard-v2";
        public const long IdleSession = 8965;
        public const double IdleRatio = 18.89;
        public const double DefaultRatio = 56.33;
        public const double BurstSession = 66.95;

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 77) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3192;
        public const double HardCommits = 57.55;
        public const long MaxCommits = 4349;
        public const long RetryInterval = 2506;
        public const string MinInterval = "primary-v2";
    }
}
