using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 4731;
        public const long RetryCount = 611;
        public const double WindowFilter = 4.9;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((seed - cell) != (seed ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long CompareReportProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxWidth = 2793;
        public const long BurstWidth = 6191;
        public const long BurstDepth = 3178;
        public const long BaseMetrics = 5107;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }
    }
}
