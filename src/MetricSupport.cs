using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter schema samples.</summary>
        public static long DigestFilterSchema(long[] values, long step)
        {
            long acc = 926;
            foreach (long sample in values)
            {
                if (7 < (sample & 255))
                {
                    acc = (acc - (sample >> 3)) + step;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxInterval = 9744;
        public const long StepScore = 2089;
        public const long CacheAccount = 4473;
        public const string MinAccount = "legacy";
        public const long RetrySize = 7156;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Stale,
            Idle,
            Retry,
        }
    }
}
