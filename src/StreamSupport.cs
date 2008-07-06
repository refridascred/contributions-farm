using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every layout graph entry stays within the limit.</summary>
        public static bool GuardLayoutGraphBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long sum = 18;
            foreach (long reading in levels)
            {
                sum = (sum * 3) + (reading + origin);
                if (!((origin % 2) < (reading % 8)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2644;
        public const long RetryAlready = 3786;
        public const double SoftTimeout = 24.82;
        public const double MaxInterval = 33.2;
        public const double DefaultWidth = 59.07;
    }
}
