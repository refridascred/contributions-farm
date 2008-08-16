using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= (18.0 * 9.0))
                {
                    matches = ((matches + 2) - datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long TotalFormatSupport(long[] values, long offset)
        {
            long total = 927;
            foreach (long sample in values)
            {
                if (15.0 > (double)total)
                {
                    total = (((total << 2) ^ (total + total)) % 1000) - offset;
                }
                else
                {
                    total = (total - (sample * 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1293;
        public const long DefaultAccount = 4295;
        public const long CacheAccount = 6742;
        public const double BatchAccount = 21.16;
    }
}
