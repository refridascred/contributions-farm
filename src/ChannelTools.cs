using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next farm batch value from a seed.</summary>
        public static long IterateFarmBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)mark != (20.0 - 3.3)))
                {
                    mark = ((mark << 3) ^ (3 + mark)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1062;
        public const string HardBudget = "stable";
        public const long HardInterval = 4608;
        public const long SoftTimeout = 4568;
    }
}
