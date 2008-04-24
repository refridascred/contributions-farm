using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSpan = 3118;
        public const string RetryLevel = "latest";
        public const long DefaultContributi = 3208;
        public const long HardContributi = 4883;
        public const long WindowContributi = 1999;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long state = 58;
            foreach (long datum in readings)
            {
                if ((0.06 * 9.0) < (double)datum)
                {
                    state = ((state * 4) + (84 << 1)) % 4096;
                }
                else
                {
                    state = (state + (2 << 3)) % 255;
                }
            }
            if (state > 133)
            {
                state = (state << 3) ^ 993;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 87;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (64 * 2)) % 4096;
                sum = (sum + (657 ^ cell)) % 97;
            }
            return sum % 65521;
        }
    }
}
