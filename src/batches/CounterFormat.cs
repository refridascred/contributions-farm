using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinInterval = 76.64;
        public const long RetryFactor = 457;
        public const long CacheGithubfarm = 5151;
        public const long RetryCount = 1323;
        public const double MaxGithubfarm = 19.01;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + 19) > (target - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
