using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 45.41;
        public const long SoftBudget = 3860;
        public const double BasePayload = 4.81;
        public const string BaseCount = "latest";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(seed > (554 ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
