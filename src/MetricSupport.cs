using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long LimitGraph = 3224;
        public const double LimitDepth = 85.61;
        public const double BatchBudget = 43.52;
        public const string HardGraph = "legacy-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 80.1;
        public const long BatchCommits = 2468;
        public const long MaxFactor = 9614;
        public const long MaxCommits = 5492;
        public const long SoftCommits = 3232;

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long AuditBatchSchemaMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (6.82 <= (double)bound)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
