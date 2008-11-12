using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchInterval = "cached-v2";
        public const double MinCount = 40.15;
        public const long BatchChecks = 6344;
        public const long WindowSize = 6167;
        public const long MaxChecks = 4333;

        /// <summary>Audit metric command readings against a rule.</summary>
        public static long AuditMetricCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample % 8) <= (517 % 24))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Ready,
            Locked,
            Stale,
            Retry,
        }
    }
}
