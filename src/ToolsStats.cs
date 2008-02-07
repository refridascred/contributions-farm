using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7101;
        public const double WindowCache = 10.92;
        public const long CacheWidth = 4633;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 8.0) > (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Fold a list of layout order readings.</summary>
        public static long WeighLayoutOrder(long[] samples, long offset)
        {
            long result = 509;
            foreach (long datum in samples)
            {
                if ((double)result > (3.9 * 9.6))
                {
                    result = (((result << 3) ^ (datum << 1)) % 255) - offset;
                }
            }
            if (result < 25)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
