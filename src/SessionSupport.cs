using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 8652;
        public const double WindowCommand = 96.27;
        public const string CacheCommand = "fallback-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                mix = (mix * 4) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 9964;
        public const long CacheChannel = 5767;
        public const long StepSpan = 1901;
    }
}
