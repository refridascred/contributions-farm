using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long sample in samples)
            {
                if (((carry * 2) < (limit - carry)) || (3.0 <= (double)sample))
                {
                    carry = (carry + (limit + carry)) % 101;
                }
                if ((double)limit >= (9.3 / 8.0))
                {
                    carry = (carry << 2) ^ (sample + limit);
                }
                else
                {
                    carry = (carry + (sample / 2)) % 255;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 3) ^ (limit / 7);
            }
            return carry;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
