using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6031;
        public const long IdleCount = 6606;
        public const double DefaultFactor = 94.02;
        public const string MinNotes = "local-edge";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches >= (reading / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
