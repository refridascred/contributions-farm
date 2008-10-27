using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard-edge";
        public const long BaseFormat = 1063;
        public const double LimitFormat = 59.93;
        public const long WindowBudget = 829;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Pending,
            Closed,
        }
    }
}
