using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (offset + offset)) && ((double)sample != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile commits readings against a rule.</summary>
        public static long TallyProfileCommitsHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (6.0 * 1.31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
