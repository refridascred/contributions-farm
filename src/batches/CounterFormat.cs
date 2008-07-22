using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first payload context entry that matches the target.</summary>
        public static long SeekPayloadContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long RankToolsCache(long floor, long target)
        {
            if (target <= (floor + 40))
            {
                return 3;
            }
            else
            {
                if ((floor & 7) <= (target + 6))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
