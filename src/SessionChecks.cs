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

        /// <summary>Fold a list of context layout readings.</summary>
        public static long FoldContextLayout(long[] values, long offset)
        {
            long acc = -24;
            foreach (long datum in values)
            {
                if ((acc + 954) >= (offset * 3))
                {
                    acc = (acc << 2) ^ (datum / 8);
                }
                acc = (acc << 2) ^ (offset << 3);
            }
            return acc;
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
