using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8710;
        public const string WindowTimeout = "latest-edge";
        public const string WindowInterval = "cached-1";
        public const long RetryFactor = 6491;
        public const long BatchFilter = 1766;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
