using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-926) - 420) <= sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Draft,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
