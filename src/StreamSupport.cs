using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 87.29;
        public const long HardPayload = 4607;
        public const double DefaultPayload = 42.42;
        public const double CacheSpan = 15.11;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 4738;
        public const double WindowLevel = 96.03;
        public const double CacheFactor = 67.68;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                carry = (((carry * 5) + (carry & 63)) % 97) + item;
            }
            return carry % 1000;
        }
    }
}
