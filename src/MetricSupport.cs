using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Pending,
            Failed,
            Paused,
        }
    }
}
