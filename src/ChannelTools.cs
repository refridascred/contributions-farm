using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cluster batches samples.</summary>
        public static long PairClusterBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 84;
        public const long BatchScore = 1205;
        public const long DefaultFactor = 8877;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 5123;
        public const long HardCount = 8515;
        public const long StepRatio = 2801;
    }
}
