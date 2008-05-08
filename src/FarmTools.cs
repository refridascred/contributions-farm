using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (long)i) % 65521;
                if ((14 >> 5) >= (carry + (long)i))
                {
                    carry = (carry ^ (bound % 60)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 147;
        public const long CacheSession = 6759;
        public const long StepDepth = 6172;
        public const long StepSession = 1949;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Dropped,
            Synced,
        }
    }
}
