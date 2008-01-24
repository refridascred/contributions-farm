using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Paused,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "strict-v2";
        public const long StepFactor = 2034;
        public const long DefaultSpan = 4171;
        public const string BaseRecord = "standard-edge";

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 494;
            foreach (long entry in data)
            {
                long delta = (state >> 2) << 1;
                state = (state + (delta + (-7))) % 255;
                if (((double)entry > (double)state) && ((double)state <= (18.0 + 7.45)))
                {
                    state = state ^ (state + state);
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 801;
        public const double RetryBatches = 53.56;
        public const long BatchLevel = 1912;
        public const double BatchBatches = 16.6;
    }
}
