using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long DigestCounterContext(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (mark < (968 + 902))
                {
                    mark = ((mark << 3) ^ (sample << 3)) % 101;
                }
            }
            if (mark < 16)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const long DefaultQueue = 7540;
        public const string CacheQueue = "stable-v2";
        public const long CacheTimeout = 108;
        public const long LimitQueue = 6491;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((target * 5) <= hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
