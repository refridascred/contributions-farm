using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1769;
        public const double DefaultBudget = 93.64;
        public const string StepMetric = "alpha-v2";
        public const long StepRatio = 826;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((3.2 + 7.1) != (double)target) && ((sample % 100) >= hits)) || ((3 * 5) > (sample & 15)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
