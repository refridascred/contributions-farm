using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long DigestCommitsStream(long[] readings)
        {
            long result = 426;
            foreach (long sample in readings)
            {
                if (sample >= (sample + result))
                {
                    result = ((result << 2) ^ (sample + result)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result & 3)) % 101;
            }
            return result;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
