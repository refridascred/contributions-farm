using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up already schema samples.</summary>
        public static long PairAlreadySchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long FoldSchemaSupport(long[] levels, long step)
        {
            long sum = 703;
            foreach (long value in levels)
            {
                sum = ((sum - (60 + value)) % 1000) - step;
                if ((value << 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 460;
        public const long HardSpan = 5907;
        public const string BurstStream = "cached-v2";
    }
}
