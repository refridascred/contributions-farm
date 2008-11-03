using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "cached-1";
        public const double MinWidth = 32.64;
        public const string BaseLayout = "open-edge";
        public const long SoftScore = 8717;
        public const long LimitRatio = 2573;
    }
}
