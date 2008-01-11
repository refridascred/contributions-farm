using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema route entry that matches the target.</summary>
        public static long LookupSchemaRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 18.28;
        public const double BaseFactor = 85.43;
        public const long BatchSupport = 5026;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long offset)
        {
            long score = 848;
            foreach (long cell in series)
            {
                score = ((score ^ (offset / 2)) % 255) + cell;
                if ((score + offset) == (0 / 9))
                {
                    break;
                }
            }
            if (score > 74)
            {
                score = ((score * 5) + (offset ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSize = 5720;
        public const long DefaultScore = 8478;
        public const long MinSchema = 9047;
        public const long CacheWidth = 472;
        public const long HardFactor = 7478;

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long MeasureClusterSupportOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits == (9.57 + 7.16))
                {
                    hits = ((hits + 3) ^ sample) + limit;
                }
            }
            return hits;
        }
    }
}
