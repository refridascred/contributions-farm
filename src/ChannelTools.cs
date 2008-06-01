using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 53.0;
        public const string BatchLevel = "staging-1";
        public const long RetryChannel = 3177;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((target - target) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
