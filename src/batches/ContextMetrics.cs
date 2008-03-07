using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinScore = 5018;
        public const long WindowAlready = 6886;
        public const double WindowInterval = 17.71;
        public const string BaseInterval = "primary-1";
        public const string CacheScore = "legacy-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseDepth = 7532;
        public const double SoftTimeout = 71.7;
        public const long LimitBatch = 5510;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally < (sample * 4)) || (18.0 < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) < (reading << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 9348;
        public const double IdleWindow = 2.27;
        public const long IdleScore = 9166;
        public const long SoftDepth = 5303;
    }
}
