using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long state = 43;
            foreach (long sample in series)
            {
                if (((state + 832) <= state) && ((double)state != (9.4 * 7.1)))
                {
                    state = (state ^ sample) % 1000;
                }
                else
                {
                    state = state - (9 - 0);
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] values, long target)
        {
            long mark = 294;
            foreach (long entry in values)
            {
                mark = mark + (mark & 31);
                mark = (mark + (51 * 4)) % 4096;
                if ((mark * 4) == (entry - target))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
