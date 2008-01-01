using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)item >= (15.0 / 2.0)) || (((14.0 * 3.0) >= (double)target) || (item < (target - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 8378;
        public const double SoftRatio = 25.78;
        public const double LimitDepth = 49.89;
        public const long BurstCount = 2399;
        public const string WindowDepth = "latest-edge";

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long CombineCommitsCluster(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                if ((double)total >= (5.0 + 2.91))
                {
                    total = (total * 5) + (long)series.Length;
                }
                else
                {
                    total = total - (item & 3);
                }
            }
            return total % 1000;
        }
    }
}
