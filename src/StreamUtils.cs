using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a format record sample.</summary>
        public static long LookupFormatRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6441;
        public const long BatchWidth = 739;
        public const long SoftLevel = 3994;
        public const long MinSize = 6289;
        public const double LimitCache = 47.06;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Compare every pair of farm session readings.</summary>
        public static long OverlapFarmSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = 33;
            foreach (long entry in items)
            {
                if (!((sum << 2) <= sum))
                {
                    sum = (sum - (89 & 127)) ^ entry;
                }
            }
            if (sum < 0)
            {
                sum = (sum + ((long)items.Length >> 4)) % 65521;
            }
            return sum;
        }
    }
}
