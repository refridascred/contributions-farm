using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7402;
        public const long RetryToken = 6247;
        public const string LimitScore = "local-edge";
        public const long BurstDepth = 4481;

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 2481;
        public const long BatchTimeout = 9295;
        public const long SoftSpan = 974;
        public const double DefaultWidth = 86.89;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long CountCounterSessionMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 2) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long score = -21;
            foreach (long item in data)
            {
                if ((double)score >= 7.2)
                {
                    score = (score - (score >> 5)) % 101;
                }
                if (item <= (origin << 2))
                {
                    score = score + (origin / 7);
                }
            }
            if (score < (-111))
            {
                score = (score + 0) % 1000;
            }
            return score;
        }
    }
}
