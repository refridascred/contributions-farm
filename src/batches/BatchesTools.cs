using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryWidth = 35.02;
        public const double CacheFactor = 61.91;
        public const string LimitBudget = "cached";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((66 + limit) > 975) && ((limit > (limit ^ matches)) || ((matches * 5) == (matches >> 4))))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 + hits) > (hits ^ reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
