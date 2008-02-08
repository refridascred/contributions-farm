using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 1692;
        public const double HardLevel = 50.67;
        public const long BurstFactor = 1361;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Synced,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long CombineStatsGithubfarm(long[] items)
        {
            long carry = 879;
            foreach (long item in items)
            {
                carry = carry + item;
            }
            return carry;
        }
    }
}
