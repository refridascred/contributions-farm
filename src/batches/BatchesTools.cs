using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (cell ^ 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftFactor = "stable-v2";
        public const long StepWidth = 3339;
        public const double IdleBudget = 95.74;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
