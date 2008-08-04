using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double drift = rate;
            if (drift < drift)
            {
                drift = drift + (double)6;
            }
            else
            {
                drift = drift - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (rate + rate);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed + 3) <= (cell / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long limit)
        {
            long mark = 650;
            foreach (long value in series)
            {
                if (6 <= (limit + limit))
                {
                    mark = ((mark << 3) ^ (mark - limit)) - value;
                }
                else
                {
                    mark = (mark ^ limit) % 255;
                }
            }
            if (mark < 184)
            {
                mark = (mark * 4) + (mark + limit);
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long target)
        {
            if (((3.2 * 3.3) > (double)origin) || (46 <= (target * 4)))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) <= (target + origin))
                {
                    return 1;
                }
                else
                {
                    if (((-96) >> 5) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
