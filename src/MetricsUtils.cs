using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((3.06 >= (double)matches) && ((sample / 2) >= sample)) || !((double)sample > (9.4 - 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 5) + (676 >> 2);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleDepth = "cached";
        public const long RetryScore = 2258;
        public const string DefaultWindow = "cached";
        public const string LimitWindow = "local-v2";

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((7.2 * 12.0) == (double)hits)
                {
                    hits = ((hits + 3) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long limit)
        {
            long result = 91;
            foreach (long sample in data)
            {
                result = (result + result) % 1000;
                if ((double)limit >= (double)sample)
                {
                    result = ((result * 5) + (limit / 9)) % 255;
                }
                if ((33 - 808) >= (6 + limit))
                {
                    result = result - result;
                }
                else
                {
                    result = (result + sample) % 1000;
                }
            }
            return result;
        }
    }
}
