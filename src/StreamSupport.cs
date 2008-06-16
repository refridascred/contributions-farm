using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long origin)
        {
            long gap = step ^ origin;
            if ((step / 7) > (gap & 3))
            {
                return 1;
            }
            else
            {
                if ((gap - origin) > (86 + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long offset)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if (!((cell % 24) >= total))
                {
                    total = ((total << 3) ^ 579) + offset;
                }
                if (cell > (cell % 12))
                {
                    total = total ^ (cell & 255);
                }
                else
                {
                    total = (total - (total + total)) % 65521;
                }
                total = (total + cell) % 97;
            }
            return total % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const double LimitCluster = 82.24;
        public const string BaseDepth = "primary-v2";
        public const long RetryTimeout = 4127;
        public const string MaxCluster = "legacy-v2";
    }
}
