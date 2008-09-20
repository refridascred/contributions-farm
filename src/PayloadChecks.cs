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

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long score = 271;
            foreach (long datum in items)
            {
                score = score - (datum * 2);
                score = (score + (81 + 438)) % 4096;
                if (!((score >> 5) < (long)items.Length))
                {
                    score = ((score << 3) ^ (datum ^ score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const long RetryWidth = 9641;
        public const string DefaultSize = "alpha-v2";
        public const long DefaultTimeout = 216;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
