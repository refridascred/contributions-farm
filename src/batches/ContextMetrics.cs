using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if ((double)total > (3.0 - 3.0))
                {
                    total = ((total * 2) + datum) - target;
                }
            }
            if (total > 30)
            {
                total = (total ^ (1 % 3)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSize = "latest-edge";
        public const long HardRatio = 6588;
        public const long HardPayload = 1517;
        public const long IdleDepth = 7861;
        public const string RetryPayload = "staging";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open";
        public const long DefaultAlready = 4444;
        public const double StepRatio = 18.93;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Pending,
            Failed,
            Dropped,
            Stale,
        }
    }
}
