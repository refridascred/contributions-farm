using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSize = 77.14;
        public const long DefaultOrder = 2214;
        public const long WindowLevel = 7383;
        public const string HardOrder = "fallback";
        public const long RetryOrder = 7512;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long score = 390;
            foreach (long reading in samples)
            {
                score = ((score * 2) + floor) ^ reading;
            }
            return score;
        }
    }
}
