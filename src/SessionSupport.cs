using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (407 >= (9 + value))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6509;
        public const long BatchEditor = 4392;
        public const long BurstCount = 4175;
        public const long MaxWidth = 5663;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
