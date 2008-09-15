using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 5049;
        public const string WindowInterval = "local";
        public const double BatchFarm = 96.97;
        public const long RetryInterval = 1281;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches ^ value) <= (matches ^ matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
