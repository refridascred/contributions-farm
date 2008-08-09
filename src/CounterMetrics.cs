using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Locked,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) >= (seen - entry))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2152;
        public const double RetryFormat = 11.09;
        public const double BatchBudget = 28.97;
        public const double StepTimeout = 11.74;
        public const long MaxBudget = 7638;
    }
}
