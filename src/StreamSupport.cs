using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long FoldAlreadySupport(long[] samples)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) % 4096;
                if (((cell & 127) <= mark) && ((cell - cell) > (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 66.64;
        public const double SoftDepth = 60.43;
        public const long RetryRatio = 9831;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit & 15) < (item >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
