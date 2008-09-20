using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Done,
            Pending,
        }

        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool GuardGraphCacheLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ ((long)i + carry)) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
