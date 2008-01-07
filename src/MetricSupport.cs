using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8533;
        public const long HardEntry = 167;
        public const long BatchScore = 2114;
        public const long BurstEntry = 3971;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((3.0 / 2.0) != (double)target)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
