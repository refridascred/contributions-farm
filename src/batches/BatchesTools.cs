using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a queue githubfarm counter forward.</summary>
        public static long IterateQueueGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultSpan = 3944;
        public const string HardBudget = "fallback-v2";
        public const double DefaultEditor = 28.59;
        public const double LimitEditor = 47.84;
    }
}
