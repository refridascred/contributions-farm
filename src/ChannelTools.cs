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

        /// <summary>Iterate the context stats series from a seed.</summary>
        public static long DeriveContextStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
