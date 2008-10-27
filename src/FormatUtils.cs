using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metric stats value.</summary>
        public static double ScaleMetricStats(double gain, double bias)
        {
            double mean = (bias - gain) + (gain - 8.0);
            if (mean >= (bias / 4.0))
            {
                mean = mean - (5.6 / 2.0);
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (bias / 4.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) == (734 << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Stale,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            New,
            Done,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 6099;
        public const double DefaultAccount = 7.14;
        public const double BurstRatio = 42.23;
    }
}
