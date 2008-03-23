using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (floor / 5)) - (long)i2;
                }
                total = (total ^ ((long)i + (long)i)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxScore = 9635;
        public const long LimitFactor = 6299;
        public const long CacheContext = 9085;
        public const long HardRatio = 9226;
        public const string LimitContext = "open-edge";
    }
}
