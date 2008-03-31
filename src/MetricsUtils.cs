using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 599;
        public const long BaseBudget = 687;
        public const long StepFactor = 5498;
        public const long StepTimeout = 6244;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long BurstScore = 8255;
        public const string BurstRecord = "fallback-v2";
        public const string LimitRecord = "alpha-1";
        public const string MinRecord = "strict-v2";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Done,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "stable-v2";
        public const long CacheScore = 9278;
        public const long WindowCount = 5237;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = -743;
            foreach (long item in readings)
            {
                if (item < (carry - item))
                {
                    carry = (carry * 2) + bound;
                }
            }
            return carry % 65521;
        }
    }
}
