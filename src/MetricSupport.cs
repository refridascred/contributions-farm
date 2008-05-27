using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading / 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8761;
        public const string LimitCount = "primary";
        public const long WindowSize = 8529;
        public const long BaseCount = 8675;
        public const long CacheMetrics = 5021;

        /// <summary>Accumulate filter queue samples.</summary>
        public static long DigestFilterQueue(long[] data, long origin)
        {
            long acc = 59;
            foreach (long value in data)
            {
                if ((acc - acc) != (origin + origin))
                {
                    acc = (((acc << 3) ^ (origin + (-7))) % 101) ^ value;
                }
                else
                {
                    acc = (acc * 2) + origin;
                }
            }
            return acc;
        }
    }
}
