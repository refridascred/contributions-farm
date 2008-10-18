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

        /// <summary>Iterate the commits session series from a seed.</summary>
        public static long RollCommitsSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target * 4) == (mark << 3))
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 101;
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
