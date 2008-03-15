using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepCount = "staging-1";
        public const double MinWindow = 71.2;
        public const long DefaultCount = 2351;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 74.43;
        public const long HardWidth = 7857;
        public const string WindowStream = "strict-v2";
        public const double BurstStream = 59.61;
        public const string CacheFactor = "strict-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9149;
        public const double MinSpan = 26.3;
        public const string WindowDepth = "primary-edge";
        public const long RetryTimeout = 3919;

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] data, long offset)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                mix = (((mix ^ ((-980) & 255)) % 101) + entry) - offset;
            }
            if (mix < 635)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 1000;
        }
    }
}
