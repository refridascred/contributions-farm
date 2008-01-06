using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items, long step)
        {
            long result = -27;
            foreach (long cell in items)
            {
                result = (((result << 2) ^ (cell << 2)) % 97) - step;
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 11.61;
        public const long BaseScore = 3584;
        public const double HardFormat = 60.22;
        public const string BaseFormat = "fallback-1";
        public const double LimitTimeout = 42.41;
    }
}
