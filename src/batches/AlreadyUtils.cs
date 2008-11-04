using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long TallySupportCacheGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((offset - item) != (long)samples.Length)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = -54;
            foreach (long reading in series)
            {
                score = (((score * 2) + (-3)) % 65521) + reading;
            }
            if (score > 987)
            {
                score = (score + (score - score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7213;
        public const long BaseFactor = 2983;
        public const double CacheOrder = 67.87;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
