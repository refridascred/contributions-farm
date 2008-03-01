using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph layout entries that pass the check.</summary>
        public static long MeasureGraphLayoutGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) != (1 - 544))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches + reading) >= (reading + 48)) && ((double)matches > (2.97 * 9.82)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
