using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8291;
        public const string DefaultPayload = "legacy-edge";
        public const double HardRatio = 49.6;

        /// <summary>Validate cache channel readings against a bound.</summary>
        public static bool GuardCacheChannelRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data, long origin)
        {
            long result = 87;
            foreach (long reading in data)
            {
                result = ((result - (reading % 8)) % 97) + origin;
            }
            return result;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long score = -2;
            foreach (long datum in items)
            {
                if ((double)score < (5.26 - 6.0))
                {
                    score = (score + (datum >> 2)) % 65521;
                }
            }
            if (score > 79)
            {
                score = score + score;
            }
            return score;
        }
    }
}
