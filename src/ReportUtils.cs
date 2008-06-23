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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 8924;
        public const long BurstSize = 4142;
        public const double RetryLevel = 42.41;
    }
}
