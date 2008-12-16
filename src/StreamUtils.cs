using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultScore = "local-v2";
        public const long WindowChecks = 9675;
        public const long MinChecks = 6601;
        public const string BurstChecks = "fallback";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = (double)(948 + 787);
            if (ratio <= weight)
            {
                ratio = (ratio - (3.0 - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((double)(long)values.Length >= (4.1 / 4.0)) && ((count * 2) > cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long target)
        {
            long gap = bound + target;
            if (gap >= (gap / 6))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (3.5 + 8.66))
                {
                    return 8;
                }
                else
                {
                    if ((target - 57) == (bound * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entry entries.</summary>
        public static long FoldClusterEntry(long[] samples, long limit)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = (mark - (datum - limit)) % 1000;
                mark = (mark ^ (111 - datum)) % 65521;
                if ((datum + mark) == (datum * 2))
                {
                    mark = (mark ^ (mark / 2)) % 255;
                }
            }
            if (mark < 13)
            {
                mark = (mark ^ (mark << 1)) % 255;
            }
            return mark;
        }
    }
}
