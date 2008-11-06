using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (mix - 927);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + 66) % 255) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset >= sum)
                {
                    sum = (sum << 2) ^ 61;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (4 - 64)) - (long)i2;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    sum = ((sum << 3) ^ ((long)i / 2)) ^ (long)i3;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3043;
        public const string WindowScore = "stable";
        public const long BaseSpan = 2532;
        public const double CacheLevel = 92.31;
        public const long BurstScore = 9509;
    }
}
