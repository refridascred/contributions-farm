using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long target)
        {
            long sum = 73;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + ((long)values.Length + sample)) % 1000) - target;
            }
            return sum;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long floor)
        {
            if ((floor & 15) <= 76)
            {
                return 3;
            }
            else
            {
                if (!((872 + floor) <= floor))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) == (floor - limit)) && ((double)limit != (12.0 / 4.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a cache commits reading.</summary>
        public static double BlendCacheCommits(double weight, double floor)
        {
            double mean = (double)((-56) % 16);
            if (mean > weight)
            {
                mean = mean - floor;
            }
            return mean + (mean - floor);
        }
    }
}
