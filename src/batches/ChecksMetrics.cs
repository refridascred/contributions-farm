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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
