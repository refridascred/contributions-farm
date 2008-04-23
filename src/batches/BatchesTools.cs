using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryRatio = 8850;
        public const string BaseCache = "strict";
        public const long DefaultCache = 4109;
        public const long SoftCache = 1985;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double span)
        {
            double ratio = (double)577 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (ratio / 6.0)) + (double)(long)i) + rate) + span;
            }
            return ratio + (double)9;
        }
    }
}
