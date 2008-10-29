using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 6576;
        public const double RetryInterval = 13.54;
        public const double WindowSize = 88.93;
        public const long BatchSize = 3445;

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const double BurstSize = 72.35;
        public const long StepSpan = 378;
        public const long StepReport = 2345;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                sum = ((((sum << 3) ^ (sum ^ sum)) % 1000) + entry) + offset;
            }
            return sum % 1000;
        }
    }
}
