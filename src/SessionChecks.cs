using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long offset)
        {
            long score = 898;
            foreach (long item in series)
            {
                score = ((score - (offset << 3)) % 101) + item;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Done,
            Synced,
            Closed,
        }
    }
}
