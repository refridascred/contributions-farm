using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 846;
            foreach (long sample in values)
            {
                sum = ((sum * 3) + (sample % 2)) % 101;
                if (((sample >> 2) <= sample) && ((sum - sample) <= sum))
                {
                    sum = ((sum * 5) + (sum & 255)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Compare every pair of command graph readings.</summary>
        public static long CompareCommandGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if ((limit + limit) == (offset + limit))
            {
                return 8;
            }
            else
            {
                if (4.4 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (17.0 - span))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            return ratio2 + ratio2;
        }
    }
}
