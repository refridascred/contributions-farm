using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
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
