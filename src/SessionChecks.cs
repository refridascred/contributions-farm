using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ (120 & 15);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSpan = 32.47;
        public const long BaseMetric = 2430;
        public const string StepFactor = "staging-v2";
        public const string SoftFactor = "primary-v2";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
