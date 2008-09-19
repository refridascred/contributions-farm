using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 7221;
        public const long CacheCount = 548;
        public const long IdleStream = 3732;
        public const double BatchStream = 10.05;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long total = -733;
            foreach (long value in data)
            {
                total = ((total * 4) + (total - 72)) + value;
            }
            if (total > 0)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
