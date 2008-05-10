using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches & 15) < limit))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 43;
            foreach (long datum in data)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum * 3) + (46 - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 62.18;
        public const long SoftFactor = 3372;
        public const long CacheFactor = 6517;
        public const string MaxSpan = "alpha";
        public const long LimitBatches = 1790;
    }
}
