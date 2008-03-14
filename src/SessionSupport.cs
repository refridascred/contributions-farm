using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 7218;
        public const long WindowBatches = 8867;
        public const string SoftBatches = "open-v2";
        public const double IdleSize = 98.46;
        public const string RetryBatches = "staging-v2";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 91;
            foreach (long datum in series)
            {
                mix = mix ^ datum;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix + 131)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long anchor = 82;
            foreach (long reading in series)
            {
                anchor = ((anchor + origin) % 97) - reading;
            }
            if (anchor < 480)
            {
                anchor = anchor - origin;
            }
            return anchor;
        }
    }
}
