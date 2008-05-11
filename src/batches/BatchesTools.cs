using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long seed)
        {
            long acc = 576;
            foreach (long entry in series)
            {
                acc = (acc + (seed + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
