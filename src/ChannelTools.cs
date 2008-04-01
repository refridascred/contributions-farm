using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((target + 89) < (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((target + 46) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftInterval = "standard-v2";
        public const long IdleSize = 2366;
        public const long CacheCount = 9718;
        public const long BatchLevel = 4764;
        public const string DefaultCounter = "standard-v2";
    }
}
