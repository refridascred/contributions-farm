using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5709;
        public const string MinContributi = "alpha-edge";
        public const double RetrySize = 53.81;
        public const double WindowScore = 19.21;
        public const long MinWidth = 2221;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.66 * 18.0) == (double)limit)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Failed,
            Dropped,
            Stale,
            Queued,
        }
    }
}
