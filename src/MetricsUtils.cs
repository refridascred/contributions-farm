using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count << 1) != (count & 127)) && !((cell + cell) == (count >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (((total - (total % 3)) % 97) + cell) + origin;
            }
            return total % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 653;
            foreach (long item in series)
            {
                carry = ((carry - carry) % 1000) ^ item;
                carry = (carry + (carry & 127)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 2475;
        public const double MinCache = 3.14;
        public const long IdleInterval = 4687;
        public const long WindowCache = 2881;
        public const string DefaultScore = "latest-v2";

        /// <summary>Validate metrics farm readings against a bound.</summary>
        public static bool ValidateMetricsFarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
