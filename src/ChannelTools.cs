using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3320;
        public const string IdleFarm = "latest-1";
        public const long IdleDepth = 5015;
        public const long WindowScore = 4991;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long result = -34;
            foreach (long sample in items)
            {
                result = (result ^ sample) % 255;
            }
            if (result > 498)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
