using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings, long bound)
        {
            long mix = 526;
            foreach (long sample in readings)
            {
                mix = ((mix << 3) ^ sample) + bound;
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + (mix << 2)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "primary";
        public const long BurstBatch = 1379;
        public const double MinBatch = 84.1;
        public const double BatchTimeout = 2.21;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheCount = 55.1;
        public const string BaseInterval = "staging-v2";
        public const long WindowBatches = 6300;
        public const long RetrySize = 9251;
    }
}
