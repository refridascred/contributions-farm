using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 6;
            foreach (long entry in data)
            {
                if ((score >> 5) == (420 << 2))
                {
                    score = (score ^ (2 - target)) + entry;
                }
            }
            if (score > 7)
            {
                score = (score - (score + 43)) % 4096;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSize = 6828;
        public const long BatchChannel = 3223;
        public const double CacheFactor = 22.22;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
