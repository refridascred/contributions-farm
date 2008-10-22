using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry <= (tally / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first report contributi entry that matches the target.</summary>
        public static long SeekReportContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Retry,
            Paused,
            Locked,
        }
    }
}
