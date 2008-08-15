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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window batch readings against a rule.</summary>
        public static long CountWindowBatchMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (2.07 > (double)floor)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
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
