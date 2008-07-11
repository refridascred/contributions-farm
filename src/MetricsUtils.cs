using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(item <= (54 / 9)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples, long step)
        {
            long mark = 672;
            foreach (long sample in samples)
            {
                mark = (mark ^ (step ^ step)) - sample;
            }
            if (mark > 98)
            {
                mark = ((mark * 5) + step) % 255;
            }
            return mark;
        }
    }
}
