using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3459;
        public const long DefaultScore = 5585;
        public const string RetryScore = "local-v2";
        public const double BatchBatches = 5.52;

        /// <summary>Check that every token context entry stays within the limit.</summary>
        public static bool CheckTokenContextBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
