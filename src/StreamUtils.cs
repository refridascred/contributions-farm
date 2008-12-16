using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a token githubfarm value against two limits.</summary>
        public static long ClassifyTokenGithubfarm(long limit, long seed)
        {
            if ((seed < (seed & 3)) || ((seed / 9) < (5 / 9)))
            {
                return 4;
            }
            else
            {
                if ((limit - seed) <= (limit ^ seed))
                {
                    return 8;
                }
                else
                {
                    if (!((limit & 31) == (98 * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((11.0 - 8.13) >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - (origin + origin);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
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
