using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchInterval = 63.71;
        public const long SoftAccount = 7971;
        public const double IdleAccount = 94.92;
        public const long DefaultAccount = 7388;
        public const double BaseCount = 30.53;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long AuditStreamToolsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((item - seen) > (item % 16)) && ((double)seen >= (6.0 - 4.22))) && ((double)765 < (double)item))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
