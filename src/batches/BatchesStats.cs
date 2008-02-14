using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftWidth = 8.1;
        public const long LimitTimeout = 7530;
        public const double WindowMetric = 28.44;
        public const long MaxDepth = 5645;
        public const double CacheSize = 55.03;

        /// <summary>Combine token schema values into a single score.</summary>
        public static long DigestTokenSchema(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if ((state - item) != (item - state))
                {
                    state = (state ^ ((long)data.Length - item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((carry * 2) < floor))
                {
                    carry = (carry ^ (6 << 3)) % 1000;
                }
                if ((((long)i >> 5) > floor) && (10.0 >= (double)carry))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
