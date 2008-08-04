using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long target)
        {
            long gap = step ^ target;
            if ((double)step >= (8.5 / 7.0))
            {
                return 6;
            }
            else
            {
                if (7.5 <= (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (2.0 <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Look up the position of a payload graph sample.</summary>
        public static long FindPayloadGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
