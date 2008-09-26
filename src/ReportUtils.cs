using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (7 + (long)i)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Combine editor account values into a single score.</summary>
        public static long ScoreEditorAccount(long[] levels, long limit)
        {
            long score = 48;
            foreach (long sample in levels)
            {
                if ((sample <= (score * 5)) && ((608 - limit) <= (sample - score)))
                {
                    score = score ^ (limit / 3);
                }
            }
            if (score < 84)
            {
                score = (score - (score >> 4)) % 4096;
            }
            return score;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
