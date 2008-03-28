using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if (!(((-92) + mark) < (datum >> 1)))
                {
                    mark = mark ^ (5 >> 3);
                }
                else
                {
                    mark = (mark ^ datum) % 65521;
                }
            }
            if (mark > (-98))
            {
                mark = ((mark << 2) ^ (floor ^ floor)) % 4096;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "standard-edge";
        public const long BaseStream = 5923;
        public const long StepInterval = 7238;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
