using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long limit)
        {
            if (!((44 + limit) == (bound >> 4)))
            {
                return 7;
            }
            else
            {
                if ((2 + bound) < 276)
                {
                    return 6;
                }
                else
                {
                    if (limit > (limit * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.0 - 1.0) >= (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            New,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long seed)
        {
            long sum = 75;
            foreach (long entry in series)
            {
                sum = ((sum * 5) + (entry ^ seed)) % 4096;
                if (((seed & 31) > (seed + sum)) || ((sum % 60) > (entry - sum)))
                {
                    sum = (sum - entry) % 65521;
                }
            }
            return sum;
        }
    }
}
