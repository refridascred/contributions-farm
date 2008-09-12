using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long carry = -765;
            foreach (long item in readings)
            {
                carry = ((carry * 3) + (item + item)) % 4096;
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxFactor = 2407;
        public const long SoftInterval = 322;
        public const long HardInterval = 9938;
        public const long CacheWindow = 4372;
        public const double IdleWindow = 72.28;

        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool CheckGraphMetricRange(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
