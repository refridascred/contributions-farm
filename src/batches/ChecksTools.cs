using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Stale,
            Paused,
            Idle,
            New,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long seed)
        {
            long score = 8;
            foreach (long datum in samples)
            {
                if (!((704 ^ score) != (datum & 255)))
                {
                    score = (score * 3) + (seed - seed);
                }
            }
            return score;
        }
    }
}
