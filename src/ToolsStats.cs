using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            if ((double)bound < (5.0 * 4.46))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) <= (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 3878;
        public const long BurstLevel = 1850;
        public const long IdleDepth = 8450;
        public const long StepBudget = 1627;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine editor report values into a single score.</summary>
        public static long DigestEditorReport(long[] series, long limit)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = ((total * 5) + value) - limit;
            }
            return total % 97;
        }
    }
}
