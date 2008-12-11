using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (state ^ 74);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Compare every pair of context metrics readings.</summary>
        public static long CompareContextMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double bias = 5.2;
            if (bias <= floor)
            {
                bias = (bias - (bias + 9.3)) - rate;
            }
            else
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias - 7.52;
        }
    }
}
