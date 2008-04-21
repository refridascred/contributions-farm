using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((sample - (-81)) == (seen >> 2)) || ((limit << 2) >= limit)) || ((seen * 3) >= (sample << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
