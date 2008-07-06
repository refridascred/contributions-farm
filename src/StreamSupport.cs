using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6173;
        public const long IdleBudget = 4621;
        public const long LimitAccount = 6192;
        public const long SoftAccount = 7208;
        public const long CacheRatio = 292;

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long FoldBatchGraph(long[] readings, long offset)
        {
            long anchor = 49;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (sample - (-5))) % 255) + offset;
            }
            return anchor;
        }
    }
}
