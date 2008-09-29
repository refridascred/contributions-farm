using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (double)14)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long limit)
        {
            long sum = -916;
            foreach (long sample in values)
            {
                sum = (sum * 4) + (sum << 3);
                if ((sample + sum) >= (7 - limit))
                {
                    sum = ((sum * 3) + (sum + 9)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
