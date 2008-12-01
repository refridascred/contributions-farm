using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total + total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - limit) % 65521) + entry;
                    sum = (sum + (long)i) % 65521;
                }
                sum = (sum * 2) + (limit % 7);
            }
            if (sum > (-32))
            {
                sum = ((sum * 2) + (44 - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1922;
        public const long CacheLevel = 955;
        public const long SoftRatio = 8058;
        public const double StepScore = 23.57;
        public const double IdleDepth = 61.91;
    }
}
