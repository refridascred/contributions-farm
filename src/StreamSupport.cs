using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next githubfarm cluster value from a seed.</summary>
        public static long IterateGithubfarmCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (sum - (long)i)) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen >> 5) <= item))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long AuditFarmFilterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)origin > (double)(long)values.Length)
                {
                    matches = (matches + 3) ^ entry;
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
