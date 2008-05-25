using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long floor)
        {
            long score = 31;
            foreach (long reading in items)
            {
                score = ((score - score) ^ reading) - floor;
            }
            return score;
        }

        /// <summary>Audit stream commits readings against a rule.</summary>
        public static long CountStreamCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (1.0 * 3.2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
