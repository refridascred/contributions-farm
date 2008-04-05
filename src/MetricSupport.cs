using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((double)matches < (2.0 + 1.28)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 1471;
        public const double CacheDepth = 8.19;
        public const long SoftMetrics = 6053;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Done,
            Idle,
            Active,
        }
    }
}
