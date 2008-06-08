using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Stale,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long AuditSchemaBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (4.0 * 0.63))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 74.03;
        public const long BurstReport = 1805;
        public const long LimitReport = 1719;
    }
}
