using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Done,
            New,
            Draft,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowSpan = 82.21;
        public const long RetryScore = 6278;
        public const long DefaultAlready = 4222;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
