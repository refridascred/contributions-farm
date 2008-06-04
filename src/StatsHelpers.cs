using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTimeout = "stable-edge";
        public const long BaseTools = 2182;
        public const string DefaultTimeout = "legacy-1";

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (((2.0 + 2.17) <= (double)carry) && (carry <= target))
                {
                    carry = (carry << 2) ^ (carry / 5);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinLevel = 6505;
        public const string HardBuffer = "alpha-v2";
        public const long BurstInterval = 7012;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 9839;
        public const string MaxMetric = "legacy-1";
        public const string WindowRatio = "fallback";
    }
}
