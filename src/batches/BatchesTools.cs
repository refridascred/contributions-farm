using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command farm entries.</summary>
        public static long FoldCommandFarm(long[] readings)
        {
            long state = 80;
            foreach (long datum in readings)
            {
                if ((double)datum <= 7.7)
                {
                    state = (state - (795 + datum)) % 4096;
                }
            }
            if (state > 27)
            {
                state = (state + (state << 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long origin)
        {
            long prev = target + origin;
            if (!(prev >= (prev << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (0.38 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
