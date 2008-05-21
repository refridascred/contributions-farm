using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool GuardChecksCacheLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool VerifyRouteContributiBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
