using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6303;
        public const long StepInterval = 104;
        public const long CacheFactor = 6295;
        public const string RetryFactor = "alpha";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((95 << 1) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (2.1 < 1.8)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item < (32 % 24))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if (((datum - (-4)) != (total - total)) && ((datum << 2) >= (573 % 100)))
                {
                    total = (((total << 3) ^ datum) % 97) + step;
                }
            }
            return total % 1000;
        }
    }
}
