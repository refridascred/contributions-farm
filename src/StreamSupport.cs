using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long carry = 259;
            foreach (long entry in readings)
            {
                carry = (((carry * 3) + (68 * 3)) % 65521) ^ entry;
            }
            if (carry > 3)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Validate schema batch readings against a bound.</summary>
        public static bool CheckSchemaBatchLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-v2";
        public const string CacheMetric = "alpha-edge";
        public const long BatchSpan = 502;
        public const long StepRatio = 1756;
    }
}
