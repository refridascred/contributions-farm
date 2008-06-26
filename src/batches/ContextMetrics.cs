using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 247;
            foreach (long reading in series)
            {
                if ((state >> 5) <= state)
                {
                    state = ((state - (state >> 2)) % 255) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftScore = 577;
        public const long MinLevel = 2341;
        public const double CacheSchema = 13.03;
        public const long MinRatio = 249;
        public const long WindowDepth = 5138;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 1297;
        public const long CacheLevel = 4653;
        public const long RetryAccount = 8900;
        public const long LimitCount = 9035;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = (score - (35 + 2)) % 97;
                if (!(4 <= (datum * 4)))
                {
                    score = ((score * 4) + (score + datum)) % 255;
                }
                else
                {
                    score = (score + (score - score)) % 255;
                }
            }
            return score;
        }
    }
}
