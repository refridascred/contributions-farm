using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 3) + (item << 1);
                sum = (sum + (sum + item)) % 255;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 415;
        public const long BaseFarm = 7419;
        public const double RetryCount = 46.52;
        public const string HardFarm = "latest-v2";

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
