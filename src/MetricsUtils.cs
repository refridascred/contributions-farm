using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((2.38 * 15.0) > (double)datum) || ((bound + hits) != (datum * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if (((-944) >= (cell + 4)) || ((limit % 8) <= (limit * 4)))
                {
                    state = state ^ limit;
                }
            }
            return state;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long limit)
        {
            long carry = 30;
            foreach (long entry in series)
            {
                carry = carry ^ (carry ^ entry);
                carry = carry + (-74);
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
