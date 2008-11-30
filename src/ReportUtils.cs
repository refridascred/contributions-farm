using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseWidth = "standard";
        public const long CacheEntry = 7272;
        public const long WindowEntry = 295;
        public const long RetryDepth = 2710;

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 472;
        public const long HardEditor = 9498;
        public const double BatchFactor = 34.17;
        public const long IdleSpan = 9389;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowFactor = 1367;
        public const long BatchInterval = 8595;
        public const string WindowWidth = "cached-v2";
        public const long BasePayload = 8574;
    }
}
