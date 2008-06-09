using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 63.27;
        public const long IdleTimeout = 4284;
        public const long MinAlready = 6005;
        public const long CacheDepth = 1671;
        public const double MaxTimeout = 32.69;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long sum = 132;
            foreach (long entry in values)
            {
                sum = sum + (8 >> 3);
                sum = (sum + (entry - 6)) % 97;
            }
            if (sum > 3)
            {
                sum = ((sum * 2) + (sum % 60)) % 255;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            long slot = target + seed;
            if ((((-42) * 5) <= slot) && ((seed - 25) < (slot + seed)))
            {
                return 1;
            }
            else
            {
                if (((710 >> 5) <= seed) || ((slot >> 3) != (345 + 8)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
