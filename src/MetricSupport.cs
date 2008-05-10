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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long seed)
        {
            long sum = -24;
            foreach (long item in items)
            {
                sum = (sum ^ (86 + seed)) % 65521;
                if (!((593 ^ sum) == (item + item)))
                {
                    sum = ((sum * 3) + (sum << 1)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 62.18;
        public const long SoftFactor = 3372;
        public const long CacheFactor = 6517;
        public const string MaxSpan = "alpha";
        public const long LimitBatches = 1790;
    }
}
