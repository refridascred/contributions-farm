using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((matches << 1) >= ((long)data.Length + limit)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
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
