using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "alpha";
        public const long DefaultPayload = 9453;
        public const long BatchCount = 4597;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)target >= 1.28)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
