using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((-2) > (datum ^ 834))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 5854;
        public const double HardSpan = 4.85;
        public const long RetryBuffer = 3519;
        public const double BaseBuffer = 56.61;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseBudget = "staging-v2";
        public const double StepBudget = 93.29;
        public const long RetrySize = 6423;
        public const long CacheWidth = 4070;
    }
}
