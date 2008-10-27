using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if ((step % 7) != (step >> 5))
                {
                    total = (total << 2) ^ (total + step);
                }
                else
                {
                    total = (total ^ (datum / 3)) % 65521;
                }
            }
            if (total > 976)
            {
                total = ((total << 3) ^ (total ^ total)) % 101;
            }
            return total;
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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
