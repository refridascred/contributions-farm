using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long origin)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = (((total * 3) + (long)samples.Length) % 255) + entry;
            }
            if (total > 65)
            {
                total = (total - (origin & 31)) % 101;
            }
            return total;
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

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double load = (double)(31 * 4);
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (9.0 * 5.32)) - (double)(long)i) + bias) - floor;
            }
            return load + (load * 8.54);
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
