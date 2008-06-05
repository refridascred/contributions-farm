using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)12 > (double)sample)
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 8.62;
        public const long RetryContributi = 1867;
        public const long CacheContributi = 8837;
        public const long BaseContributi = 562;
    }
}
