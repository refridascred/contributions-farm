using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 42;
            foreach (long entry in samples)
            {
                if ((score + score) >= (entry >> 3))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (4.0 / 9.0)) && (((limit << 2) > reading) || ((limit + reading) < (reading + 982))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1731;
        public const double StepEditor = 66.46;
        public const string DefaultEditor = "staging-v2";
    }
}
