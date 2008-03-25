using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 4395;
        public const long HardCache = 2891;
        public const string CacheCount = "latest";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - seed) < (399 << 3))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2189;
        public const string SoftFarm = "legacy-1";
        public const double MaxBudget = 15.4;
        public const long SoftRatio = 6948;

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long CountCounterClusterOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((double)item <= (3.0 / 4.0)) && (((count + item) >= 7) || ((bound / 5) >= (3 * 3))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
