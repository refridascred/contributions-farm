using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 8169;
        public const long MinRatio = 7150;
        public const long BurstBudget = 1188;
        public const double WindowOrder = 96.23;
        public const long StepOrder = 5832;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((5.73 * 5.08) <= (double)cell)
                {
                    total = (total << 3) ^ (346 >> 5);
                }
            }
            if (total < (-5))
            {
                total = (total - (total ^ total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Synced,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample <= 17) && (7.6 <= (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
