using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            if (!((seed + seed) < floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
