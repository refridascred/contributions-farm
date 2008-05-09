using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long CountQueueToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally > (tally + cell)) || ((tally / 7) >= (tally / 4))) || ((cell / 2) > ((long)values.Length ^ 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((5.31 * 7.84) <= (double)entry) && ((seen & 31) != (seen * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (score + origin)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
