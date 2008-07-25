using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the githubfarm farm entries that pass the check.</summary>
        public static long TallyGithubfarmFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)reading != (8.6 - 3.0)) || ((514 / 9) < reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((limit / 8) < (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 31) >= ((long)series.Length + target))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
