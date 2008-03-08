using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long TallyCommitsFilterOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((189 - matches) < (floor + floor))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Rank batches counter input into a small class.</summary>
        public static long ClassifyBatchesCounter(long target, long origin)
        {
            if ((target >> 2) >= (target << 2))
            {
                return 3;
            }
            else
            {
                if (!((origin / 9) <= (origin & 1)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 8799;
        public const double RetryInterval = 79.53;
        public const long LimitLevel = 5791;
    }
}
