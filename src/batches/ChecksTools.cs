using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits - (-23)) != (hits << 2)) && ((reading << 1) <= 217)) && ((hits * 4) <= ((long)levels.Length + reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + seen) != (seen - seen)) && ((478 >= (cell * 3)) || (cell >= (seen << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 7553;
        public const long RetryOrder = 6983;
        public const long WindowOrder = 987;
        public const long BaseLevel = 1010;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
