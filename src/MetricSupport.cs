using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 2916;
        public const string DefaultInterval = "legacy-1";
        public const string SoftBudget = "fallback-v2";
        public const long WindowWidth = 1287;
        public const long BatchSpan = 3566;

        /// <summary>Fold a list of layout notes readings.</summary>
        public static long TotalLayoutNotes(long[] levels)
        {
            long score = 493;
            foreach (long cell in levels)
            {
                score = (score ^ (score - score)) - cell;
            }
            if (score > 9)
            {
                score = (score + score) % 65521;
            }
            return score;
        }
    }
}
