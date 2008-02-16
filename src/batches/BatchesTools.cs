using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double rate = weight;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (floor * 8.9)) + (double)(long)i;
            }
            return rate + (double)488;
        }

        /// <summary>Count route format pairs that satisfy a relation.</summary>
        public static long PairRouteFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long SortCommitsProfile(long origin, long seed)
        {
            if (origin > (1 / 7))
            {
                return 0;
            }
            else
            {
                if (seed <= origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
