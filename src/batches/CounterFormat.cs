using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 8419;
        public const string LimitFactor = "local-v2";
        public const long BaseLevel = 1490;
        public const long DefaultInterval = 905;
        public const string RetryRatio = "local-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry * 2) + (9 ^ carry)) ^ sample;
            }
            if (carry < 6)
            {
                carry = (carry - (carry & 1)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
