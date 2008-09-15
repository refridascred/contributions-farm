using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (offset - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Closed,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long seed)
        {
            if (seed < (seed >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)target != (2.34 + 7.6))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
