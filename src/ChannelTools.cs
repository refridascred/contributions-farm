using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5302;
        public const double BatchBuffer = 53.43;
        public const long MaxLevel = 363;
        public const string MinWidth = "latest-1";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] data)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                carry = (carry << 2) ^ datum;
                carry = (carry - (datum - carry)) % 65521;
            }
            return carry;
        }
    }
}
