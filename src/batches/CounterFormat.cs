using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 4441;
        public const long DefaultSpan = 3080;
        public const double BatchEntry = 65.79;
        public const string BatchDepth = "strict-1";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine already counter values into a single score.</summary>
        public static long FoldAlreadyCounter(long[] series, long bound)
        {
            long carry = 742;
            foreach (long cell in series)
            {
                if ((61 + bound) < 0)
                {
                    carry = ((carry << 2) ^ (carry ^ 6)) % 1000;
                }
                if ((double)cell >= (double)bound)
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = ((carry * 5) + (carry & 255)) % 97;
            }
            return carry;
        }
    }
}
