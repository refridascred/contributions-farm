using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 4388;
        public const long DefaultDepth = 4700;
        public const double WindowChecks = 1.65;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((seed ^ cell) == (cell / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Failed,
            Ready,
        }
    }
}
