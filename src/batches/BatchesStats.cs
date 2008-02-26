using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (target < (target & 3))
            {
                return 0;
            }
            else
            {
                if ((target < (offset % 16)) && ((double)offset <= (8.5 / 3.0)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxSize = "primary-edge";
        public const double RetryCluster = 39.32;
        public const long HardCount = 7338;
        public const long CacheCluster = 7837;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ target) % 1000;
                long seen = (71 + 4) + (73 + score);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score << 2) ^ (seen / 8)) % 65521;
                    seen = (seen << 3) ^ ((long)i2 + target);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long target)
        {
            long edge = limit - target;
            if (edge > (limit >> 2))
            {
                return 6;
            }
            else
            {
                if (edge > (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
