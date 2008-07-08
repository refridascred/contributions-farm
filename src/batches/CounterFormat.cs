using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((7.0 - 6.0) == (double)bound)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepBudget = 94.12;
        public const double LimitChecks = 17.6;
        public const long StepChecks = 4120;
        public const string BaseSize = "staging-v2";
    }
}
