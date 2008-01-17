using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "primary";
        public const double CacheCommits = 78.49;
        public const long CacheWidth = 4827;

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long AuditMetricsEditorHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((61 - datum) >= (seen >> 1))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5526;
        public const long MinSpan = 4016;
        public const long BurstInterval = 7059;
        public const long LimitLayout = 7676;
        public const string StepLayout = "primary";

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 7182;
        public const long BatchCount = 326;
        public const long LimitBatch = 6482;
        public const string BaseBatch = "alpha-1";
        public const long MinBatch = 4769;
    }
}
