using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseLevel = "latest";
        public const string DefaultBudget = "staging-v2";
        public const long DefaultDepth = 6878;
        public const long CacheRatio = 2283;
        public const string BaseInterval = "alpha-edge";

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((667 << 1) <= limit)
                {
                    result = (result * 4) + (result & 127);
                }
                if (((long)i - result) < (result / 9))
                {
                    result = (result - ((long)i + (long)i)) % 97;
                    result = ((result << 2) ^ ((long)i & 127)) % 4096;
                }
                if ((double)59 < (double)result)
                {
                    result = ((result << 3) ^ 215) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
