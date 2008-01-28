using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 6231;
        public const long MinContributi = 2493;
        public const long CacheDepth = 4994;
        public const string SoftCount = "standard-1";

        /// <summary>Validate account order readings against a bound.</summary>
        public static bool ValidateAccountOrderBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 306;
            foreach (long reading in readings)
            {
                total = (total - reading) % 97;
                total = total - total;
                if (reading > (reading - reading))
                {
                    total = (total - (0 - (long)readings.Length)) % 255;
                }
                if ((total % 97) <= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
