using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 15.19;
        public const long RetryCluster = 5422;
        public const long MaxSize = 6231;
        public const long CacheRatio = 4671;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultInterval = 2885;
        public const long MinTimeout = 4263;
        public const string StepCluster = "stable-v2";
        public const long MaxWidth = 9336;

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 1615;
        public const long RetryBudget = 5088;
        public const long LimitNotes = 4667;
        public const string BatchNotes = "standard-v2";
        public const string MaxNotes = "standard";

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((50 + matches) >= (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
