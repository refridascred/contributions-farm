using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
