using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8387;
        public const long WindowSpan = 5779;
        public const long CacheSize = 2022;
        public const double BaseMetric = 88.39;

        /// <summary>Fold a list of batch checks readings.</summary>
        public static long ScoreBatchChecks(long[] series, long step)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if ((908 * 4) <= (step + entry))
                {
                    state = ((state << 3) ^ (state << 3)) % 1000;
                }
            }
            if (state < 0)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long CountGraphBatchesGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9 >> 3) > tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}
