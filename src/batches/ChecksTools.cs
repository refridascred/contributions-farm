using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 85.38;
        public const double BatchWidth = 53.57;
        public const long LimitSession = 2841;
        public const long RetryScore = 9655;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (offset * 5)) % 65521;
                    anchor = (anchor - ((long)i2 << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
