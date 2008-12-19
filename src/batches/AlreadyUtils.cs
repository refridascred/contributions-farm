using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Done,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 9776;
        public const double IdleContributi = 70.54;
        public const long BaseContributi = 5819;

        /// <summary>Adjust a stream contributi reading.</summary>
        public static double AdjustStreamContributi(double weight, double span)
        {
            double ratio = (13.0 / 7.0) - (double)97;
            return ((ratio - (double)5) + weight) + span;
        }

        /// <summary>Measure how many batch report samples are out of range.</summary>
        public static long AuditBatchReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) != (hits / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
