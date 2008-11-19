using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items, long step)
        {
            long state = 23;
            foreach (long entry in items)
            {
                state = (((state * 4) + (state << 3)) % 1000) ^ entry;
                if ((step & 31) >= (step * 2))
                {
                    state = (state + (step + step)) % 1000;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 1);
            }
            return state % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (entry / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)tally == (19.0 * 5.11)) || ((entry / 4) < (entry % 3)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
