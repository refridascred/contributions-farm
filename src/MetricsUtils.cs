using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long target)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor ^ (datum + 312)) % 4096) - (long)i;
                }
                anchor = (anchor + 565) % 4096;
                if (((double)target == (7.81 * 1.7)) || ((datum + target) <= ((-7) - datum)))
                {
                    anchor = (anchor + (datum << 1)) % 4096;
                }
            }
            return anchor % 1000;
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
