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

        /// <summary>Compare every pair of order route readings.</summary>
        public static long OverlapOrderRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
