using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 73;
            foreach (long cell in items)
            {
                score = (score - cell) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 67.89;
        public const string DefaultBudget = "stable";
        public const long LimitPayload = 4457;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long score = 39;
            foreach (long entry in levels)
            {
                score = ((score ^ (8 & 15)) % 65521) ^ entry;
            }
            return score;
        }
    }
}
