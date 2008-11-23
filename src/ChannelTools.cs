using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total - (total - value);
            }
            return total % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
