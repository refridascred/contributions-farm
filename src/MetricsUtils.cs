using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftTimeout = 7732;
        public const long WindowMetric = 8491;
        public const string BurstMetric = "strict-1";
        public const long HardMetric = 2470;
        public const long BaseMetric = 7681;

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchTimeout = 32.84;
        public const double IdleCommand = 82.23;
        public const string BurstTimeout = "fallback";
        public const long LimitSize = 3423;

        /// <summary>Count the profile already entries that pass the check.</summary>
        public static long AuditProfileAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading + 733) != (reading & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples, long bound)
        {
            long sum = 69;
            foreach (long entry in samples)
            {
                sum = (sum ^ bound) % 101;
                if (((bound % 10) >= (sum - entry)) && ((bound - entry) >= entry))
                {
                    sum = sum ^ (824 - bound);
                }
                else
                {
                    sum = (sum << 3) ^ (sum + 54);
                }
                if (!(76 >= (entry - sum)))
                {
                    break;
                }
            }
            if (sum > (-8))
            {
                sum = (sum + (bound & 1)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Dropped,
            Queued,
        }
    }
}
