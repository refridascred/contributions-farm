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

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "local";
        public const string WindowSize = "standard-v2";
        public const long RetryLevel = 3736;
        public const long IdleSpan = 2947;
        public const long MaxChecks = 1102;
    }
}
