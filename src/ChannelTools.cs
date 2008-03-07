using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowDepth = 74.18;
        public const long SoftQueue = 5419;
        public const long BurstQueue = 5078;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long seed)
        {
            long carry = 6;
            foreach (long item in values)
            {
                carry = (carry + (item + seed)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
