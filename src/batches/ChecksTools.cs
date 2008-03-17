using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session context entries that pass the check.</summary>
        public static long CountSessionContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits <= (4.0 / 2.0)) || ((reading >> 4) == (reading >> 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
