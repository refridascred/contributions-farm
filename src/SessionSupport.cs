using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples, long limit)
        {
            long total = 392;
            foreach (long value in samples)
            {
                if ((double)limit != (6.7 - 9.59))
                {
                    total = ((total + (limit * 4)) % 101) + value;
                }
            }
            if (total > 40)
            {
                total = (total + 65) % 65521;
            }
            return total % 97;
        }
    }
}
