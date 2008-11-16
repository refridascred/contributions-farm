using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches * 2) <= (entry << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 96.3;
        public const string RetryProfile = "alpha-v2";
        public const long StepProfile = 3630;
    }
}
