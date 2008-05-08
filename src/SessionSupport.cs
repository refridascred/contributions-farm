using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data)
        {
            long carry = 441;
            foreach (long sample in data)
            {
                if (!((carry - carry) <= (344 - sample)))
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstWidth = "primary-v2";
        public const string IdleStream = "latest";
        public const long BurstCount = 2610;
        public const long CacheSpan = 2872;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result * 2) + (result + 284);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
