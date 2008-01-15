using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values, long offset)
        {
            long total = 921;
            foreach (long sample in values)
            {
                long offset2 = (40 + total) * 5;
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total * 3) + offset2) + (long)i) + sample) + offset;
                }
                total = (total - (total - 93)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Synced,
            Pending,
            Paused,
            Locked,
        }
    }
}
