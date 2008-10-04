using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 2096;
        public const long BaseCommits = 5066;
        public const long RetryCommits = 2558;

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleLevel = 44.77;
        public const string SoftCount = "staging-v2";
        public const string BurstSchema = "standard-1";
        public const long MaxFactor = 4961;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count >= (datum >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((limit & 3) == (long)i))
                {
                    mark = (mark << 2) ^ 3;
                }
                mark = mark ^ ((long)i + mark);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9906;
        public const long BaseSupport = 8951;
        public const long LimitSupport = 6918;
        public const double CacheScore = 81.55;
    }
}
