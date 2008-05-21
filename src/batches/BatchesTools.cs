using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 2311;
        public const string BurstDepth = "legacy";
        public const string BatchRecord = "fallback";
        public const long DefaultScore = 1286;
        public const double MinDepth = 36.5;

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stats format input into a small class.</summary>
        public static long SortStatsFormat(long seed, long target)
        {
            long step = seed - target;
            if ((target - (-52)) <= (491 ^ step))
            {
                return 7;
            }
            else
            {
                if (((seed >> 5) > (target ^ 64)) && ((double)target != (19.0 - 3.8)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
