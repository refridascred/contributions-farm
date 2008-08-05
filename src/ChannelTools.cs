using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 35.73;
        public const long MaxAccount = 4610;
        public const string RetryAccount = "standard-v2";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            if (!((offset / 6) < floor))
            {
                return 7;
            }
            else
            {
                if ((385 << 2) == (floor + 728))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long target)
        {
            long offset = origin ^ target;
            if ((target + origin) < (offset / 6))
            {
                return 6;
            }
            else
            {
                if (((origin ^ offset) == (target + origin)) && (offset > (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
