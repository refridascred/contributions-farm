using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a counter token counter forward.</summary>
        public static long IterateCounterToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (limit >> 5)) % 97;
                if ((limit / 3) >= (limit % 16))
                {
                    anchor = (anchor ^ (limit >> 5)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long DigestContributiFarm(long[] data)
        {
            long sum = 822;
            foreach (long datum in data)
            {
                sum = sum ^ datum;
            }
            if (sum < (-49))
            {
                sum = (sum << 3) ^ (sum ^ 0);
            }
            return sum;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + origin) == (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9248;
        public const string MaxScore = "standard";
        public const long IdleRecord = 8154;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
