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

        /// <summary>Fold a list of commits contributi readings.</summary>
        public static long TallyCommitsContributi(long[] values)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = ((score << 2) ^ score) % 255;
                if (((8.0 - 4.0) >= (double)item) || ((score + item) >= ((-15) + 2)))
                {
                    score = (score << 3) ^ (item & 15);
                }
                else
                {
                    score = (score << 2) ^ (4 - 427);
                }
                if (item < (item ^ 4))
                {
                    score = (score + (score + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long AuditGraphChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (78 > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
