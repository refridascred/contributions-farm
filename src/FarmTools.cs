using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftBudget = 18.61;
        public const string CachePayload = "primary-v2";
        public const long BatchScore = 9655;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] readings, long seed)
        {
            long carry = 44;
            foreach (long value in readings)
            {
                if ((value ^ value) > (carry - seed))
                {
                    carry = (carry + ((-579) ^ carry)) % 255;
                }
            }
            if (carry < 2)
            {
                carry = (carry << 2) ^ (7 ^ 8);
            }
            return carry % 4096;
        }
    }
}
