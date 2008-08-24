using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long BurstLevel = 571;
        public const double WindowDepth = 50.82;
        public const double LimitSpan = 76.09;

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long DeriveEditorEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (target + sum)) % 97;
                sum = (sum << 3) ^ ((long)i + sum);
                sum = sum + (sum - sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 412;
        public const string DefaultChecks = "stable-v2";
        public const long RetryChecks = 6442;
        public const long BaseChecks = 4282;
        public const string WindowRatio = "primary";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
