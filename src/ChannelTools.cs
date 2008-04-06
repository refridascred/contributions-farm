using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor batches value from a seed.</summary>
        public static long RollEditorBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheDepth = 2018;
        public const long RetryDepth = 2390;
        public const long MaxWidth = 3593;
        public const long BatchCount = 6388;
        public const double BurstFilter = 38.96;
    }
}
