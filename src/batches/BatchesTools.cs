using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (4.7 * 3.69))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const double MaxTimeout = 53.16;
        public const long BaseLevel = 7059;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepDepth = 40.57;
        public const string HardCluster = "alpha";
        public const long DefaultCluster = 1087;
        public const long SoftCluster = 212;
        public const long BatchBudget = 9546;
    }
}
