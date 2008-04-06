using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 66.69;
        public const long LimitDepth = 7591;
        public const string CacheLayout = "local-1";
        public const long BurstTimeout = 1387;
        public const long RetryLayout = 4038;

        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long CompareNotesChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long seed)
        {
            long score = 8;
            foreach (long sample in values)
            {
                score = (score + (sample - seed)) % 101;
            }
            if (score < 62)
            {
                score = ((score * 4) + (score % 12)) % 1000;
            }
            return score % 97;
        }
    }
}
