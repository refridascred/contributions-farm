using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryRatio = "open";
        public const string WindowCount = "primary-edge";
        public const double RetryWindow = 52.95;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (seed ^ seed)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
