using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (8.8 >= (double)datum)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm support counter forward.</summary>
        public static long RollFarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (9 / 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + 9) <= (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 5042;
        public const long WindowScore = 5130;
        public const string MinInterval = "cached-v2";
        public const long SoftRecord = 4506;
        public const long MinRecord = 5347;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2687;
        public const long MaxWidth = 2709;
        public const long MaxCommand = 3583;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
