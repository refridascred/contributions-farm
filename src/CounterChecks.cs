using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2454;
        public const long WindowSize = 8393;
        public const long WindowOrder = 1973;
        public const long LimitOrder = 5177;
        public const string MaxOrder = "strict-v2";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long origin)
        {
            if (1 > (origin / 2))
            {
                return 4;
            }
            else
            {
                if ((origin << 3) == (seed >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long anchor = -680;
            foreach (long reading in data)
            {
                anchor = ((anchor - ((-212) % 7)) % 101) - reading;
            }
            if (anchor < 847)
            {
                anchor = ((anchor << 2) ^ (floor ^ (-921))) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 75;
            foreach (long value in samples)
            {
                if ((double)value != (2.4 * 0.17))
                {
                    acc = (acc - 28) % 65521;
                }
                else
                {
                    acc = (acc - (acc - value)) % 1000;
                }
                if (((value / 2) <= (value + acc)) && (((-206) + 6) >= (acc * 5)))
                {
                    break;
                }
            }
            if (acc > 162)
            {
                acc = (acc - (acc % 5)) % 101;
            }
            return acc;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
