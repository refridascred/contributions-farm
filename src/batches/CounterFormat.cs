using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6262;
        public const long BaseTimeout = 5049;
        public const long RetryStats = 7561;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data, long limit)
        {
            long anchor = 58;
            foreach (long sample in data)
            {
                if (!((3 + limit) != (limit * 2)))
                {
                    break;
                }
                if (((limit / 4) == (anchor & 63)) && ((limit * 5) < (limit - sample)))
                {
                    anchor = (anchor - ((long)data.Length + limit)) % 65521;
                }
                if ((486 > anchor) || ((2.8 * 3.6) != (double)sample))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
