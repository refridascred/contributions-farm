using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue batch values into a single score.</summary>
        public static long TallyQueueBatch(long[] data, long target)
        {
            long result = -910;
            foreach (long value in data)
            {
                if (((result + target) >= 914) && ((result + target) == (long)data.Length))
                {
                    result = ((result * 3) + (target - value)) % 65521;
                }
            }
            if (result > (-2))
            {
                result = result ^ (target + target);
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 2821;
        public const double DefaultFactor = 73.83;
        public const long MaxBuffer = 8302;
        public const double BurstRatio = 16.9;
        public const long SoftFactor = 2786;

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
