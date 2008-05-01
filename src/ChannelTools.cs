using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of already session readings.</summary>
        public static long PairAlreadySessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long MeasureContextPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((-98) ^ hits) >= (hits & 7))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
