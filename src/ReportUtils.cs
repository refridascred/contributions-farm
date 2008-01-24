using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 331;
            foreach (long item in series)
            {
                acc = (acc - (item % 64)) % 101;
                acc = acc + acc;
                if (!((3.94 / 5.0) > (double)acc))
                {
                    acc = ((acc << 2) ^ (acc + 707)) % 1000;
                }
                else
                {
                    acc = (acc * 4) + (item << 1);
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((9 ^ limit) < (count * 4)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((4.65 - 0.6) < (double)seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
