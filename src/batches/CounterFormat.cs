using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings)
        {
            long total = 6;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= total)
                {
                    total = (total * 5) + (sample % 3);
                }
                else
                {
                    total = total ^ (sample + 8);
                }
                if ((double)total > (double)4)
                {
                    break;
                }
            }
            if (total < 960)
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
