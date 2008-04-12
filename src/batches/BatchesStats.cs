using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long IdleTimeout = 5207;
        public const double MinSize = 78.59;

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if (limit > (limit * 2))
            {
                return 7;
            }
            else
            {
                if (!((20.0 / 7.0) > (double)limit))
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
