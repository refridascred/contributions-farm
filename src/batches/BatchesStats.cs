using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "primary-v2";
        public const string MinFarm = "local";
        public const long StepRatio = 3958;

        /// <summary>Audit metric entry readings against a rule.</summary>
        public static long MeasureMetricEntryGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((673 >= hits) && ((-31) >= (target & 15)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long limit)
        {
            if (target < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((limit << 1) > (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
