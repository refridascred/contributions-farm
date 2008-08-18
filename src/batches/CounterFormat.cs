using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count profile batch pairs that satisfy a relation.</summary>
        public static long PairProfileBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long BucketClusterCommand(long origin, long floor)
        {
            if ((4.97 - 2.65) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((origin << 3) >= (origin / 7))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
