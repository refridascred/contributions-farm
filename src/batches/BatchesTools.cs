using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 92;
            foreach (long sample in values)
            {
                state = (((state * 5) + (6 & 1)) % 65521) + sample;
                state = (state << 2) ^ (904 >> 2);
                state = (state - state) % 97;
            }
            if (state > 6)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long LocateCommandPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
