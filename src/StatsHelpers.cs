using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit command channel readings against a rule.</summary>
        public static long AuditCommandChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell == (double)matches) || (matches <= (6 << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long GradeGithubfarmCluster(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (!((bound2 ^ seed) != (bound2 - 61)))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.8 / 7.0)) && (bound2 <= (seed % 7)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Active,
            Pending,
            Locked,
            New,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((14.0 - 4.2) < (double)count)
                {
                    count = ((count + 2) + sample) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
