using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 6717;
        public const double RetrySpan = 41.6;
        public const string BatchLevel = "standard-v2";
        public const double CacheSpan = 52.86;
    }
}
