using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TotalStreamCluster(long[] readings, long limit)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc - (limit * 4)) ^ item;
            }
            if (acc > 5)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc % 2)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
