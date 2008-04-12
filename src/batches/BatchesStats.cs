using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((3 - 48) > (sample + floor)) || ((sample + sample) < (25 % 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 68.41;
        public const string DefaultDepth = "strict-1";
        public const double WindowCount = 41.85;
        public const long DefaultInterval = 4116;
        public const string CacheSupport = "standard";
    }
}
