using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (127 > (step + 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long CompareGithubfarmStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry - count) == (3 + (-560))) && (count < (count >> 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
