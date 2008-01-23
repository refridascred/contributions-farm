using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route graph values into a single score.</summary>
        public static long TotalRouteGraph(long[] levels)
        {
            long sum = 81;
            foreach (long entry in levels)
            {
                if ((double)sum > 2.3)
                {
                    sum = sum + (9 - entry);
                }
            }
            return sum;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (3.54 < (double)seed)
                {
                    state = (state - 7) % 1000;
                }
                state = (state - (state >> 5)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long floor)
        {
            long result = -7;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (result % 2)) + entry) - floor;
            }
            return result;
        }
    }
}
