using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of token payload readings.</summary>
        public static long WeighTokenPayload(long[] series, long seed)
        {
            long result = 5;
            foreach (long datum in series)
            {
                result = (result - (363 / 5)) + datum;
            }
            if (result > 5)
            {
                result = (result + (42 + seed)) % 255;
            }
            return result % 1000;
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
