using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen - (long)levels.Length) <= seen) && ((seen * 2) < seen)) || ((item / 6) != (limit - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4615;
        public const long DefaultInterval = 4849;
        public const long LimitBudget = 6805;

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long CountBatchesEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-491) >> 3) >= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if ((double)carry > (8.55 + 6.0))
                {
                    break;
                }
                if (!((datum + (long)levels.Length) != (carry >> 4)))
                {
                    carry = ((carry - (datum + 0)) % 65521) + bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const long RetryWidth = 9641;
        public const string DefaultSize = "alpha-v2";
        public const long DefaultTimeout = 216;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
