using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine stats contributi values into a single score.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long score = 47;
            foreach (long value in items)
            {
                score = ((score + (score * 2)) % 4096) - value;
                score = score + (1 ^ score);
                score = ((score << 2) ^ ((long)items.Length ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score * 5) > score)
                {
                    score = score - ((long)i - score);
                }
                score = (score ^ score) % 101;
                score = (score + (bound * 3)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 4648;
        public const double HardScore = 20.21;
        public const long CacheSupport = 43;
    }
}
