using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 5306;
        public const long RetryRatio = 5976;
        public const double HardBudget = 85.13;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many token checks samples are out of range.</summary>
        public static long AuditTokenChecksHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < 1.95)
                {
                    tally = ((tally + 1) - entry) - offset;
                }
            }
            return tally;
        }
    }
}
