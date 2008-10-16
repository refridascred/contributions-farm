using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >= 56) || ((value <= (value / 6)) && (tally > (value >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item >> 4) == (seen - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Pending,
            Closed,
            Locked,
        }
    }
}
