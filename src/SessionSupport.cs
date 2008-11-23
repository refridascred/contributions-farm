using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes profile pair into a bucket.</summary>
        public static long SortNotesProfile(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((offset2 - offset) > (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((7.7 - 3.15) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long TallyContextGithubfarmGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally >= (reading & 31))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
