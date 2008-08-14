using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a route contributi reading by value.</summary>
        public static long FindRouteContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((acc - acc) >= origin)
                {
                    acc = (acc ^ acc) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((cell + cell) >= (hits << 3)) || (hits > (hits >> 3))) || !(8.9 < (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 502;
        public const double RetrySize = 81.9;
        public const long CacheMetrics = 9783;
        public const double RetryMetrics = 45.48;
    }
}
