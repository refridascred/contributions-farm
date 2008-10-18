using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 3678;
        public const long LimitSize = 4366;
        public const string SoftCount = "standard";
        public const long WindowTimeout = 7695;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 99;
        public const double RetryCommand = 87.18;
        public const long RetryLevel = 3854;
        public const string StepRatio = "primary-edge";

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = mark - target;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Done,
            Queued,
        }
    }
}
