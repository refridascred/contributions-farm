using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > (count & 31))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 6083;
        public const string DefaultCommits = "standard-1";
        public const double WindowCommits = 37.79;
        public const long RetryCommits = 3028;
        public const long HardCount = 9951;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
