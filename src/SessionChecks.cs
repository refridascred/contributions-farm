using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Idle,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item ^ count) <= (item & 7))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
