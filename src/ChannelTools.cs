using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + value) >= (131 / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 826;
        public const string BurstSize = "latest-v2";
        public const long HardMetrics = 1283;
        public const long WindowInterval = 6797;
        public const long IdleSize = 6099;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
