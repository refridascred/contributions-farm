using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a context schema counter forward.</summary>
        public static long SeriesContextSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor & 127);
                anchor = (anchor ^ (855 ^ target)) % 101;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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
