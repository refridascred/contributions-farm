using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long limit)
        {
            long state = 64;
            foreach (long value in series)
            {
                state = (state ^ (limit << 2)) % 4096;
                if ((limit & 1) == (value & 31))
                {
                    break;
                }
            }
            return state % 1000;
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
