using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (target > (222 << 1))
            {
                return 4;
            }
            else
            {
                if (((7 >> 5) >= (target2 + target)) && (target < (target - target2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 6075;
        public const long DefaultGithubfarm = 1895;
        public const string CacheScore = "cached-edge";
        public const long DefaultSize = 4831;

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
