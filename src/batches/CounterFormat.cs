using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of payload session entries.</summary>
        public static long TallyPayloadSession(long[] data)
        {
            long state = 99;
            foreach (long item in data)
            {
                if (!((item >> 1) <= (state - state)))
                {
                    state = (state - (46 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftRatio = 93.63;
        public const long WindowWidth = 2597;
        public const long CacheSpan = 8164;
    }
}
