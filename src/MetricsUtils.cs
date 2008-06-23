using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Synced,
            Done,
            Paused,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((double)origin > (3.2 + 6.22)) && ((0.8 * 8.3) <= (5.09 * 3.2)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "latest-1";
        public const long StepSize = 1723;
        public const long IdleRoute = 6732;
        public const double BaseRoute = 90.11;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 59.66;
        public const long WindowScore = 3478;
        public const long RetrySize = 9914;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor < (floor - floor)) || ((sum / 9) != (803 ^ sum)))
                {
                    sum = (sum ^ (sum ^ sum)) % 1000;
                    sum = (sum ^ (6 ^ 16)) % 1000;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
