using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "cached-1";
        public const long IdleInterval = 709;
        public const long BatchChecks = 5909;
        public const double MinFactor = 61.17;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry << 3) ^ (target ^ 7)) % 4096;
                    carry = (carry - (target + (long)i2)) % 1000;
                }
                if (target < (target >> 3))
                {
                    carry = ((carry * 2) + ((long)i / 2)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
