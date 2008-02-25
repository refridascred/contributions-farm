using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes record samples are out of range.</summary>
        public static long CountNotesRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((8.6 * 2.6) == (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = state - ((long)i - step);
                state = (state ^ state) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
