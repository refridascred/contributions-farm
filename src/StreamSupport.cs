using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
