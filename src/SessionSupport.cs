using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Active,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ 6) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((9.42 + 3.5) < (double)reading) && ((454 << 2) == (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
