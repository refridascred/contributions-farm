using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = -973;
            foreach (long item in levels)
            {
                if ((item <= (sum - item)) && ((item ^ item) <= (item - 911)))
                {
                    sum = (sum << 3) ^ ((long)levels.Length % 100);
                }
            }
            if (sum > (-86))
            {
                sum = (sum << 3) ^ (sum - 496);
            }
            return sum;
        }
    }
}
