using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long carry = 74;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 97;
                if ((6.0 - 2.0) <= (double)carry)
                {
                    carry = (carry - (carry & 7)) % 255;
                }
                else
                {
                    carry = (carry + (datum - 48)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Validate profile contributi readings against a bound.</summary>
        public static bool ValidateProfileContributiLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
