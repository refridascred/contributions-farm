using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Draft,
            Stale,
            New,
            Queued,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double bias2)
        {
            double mean = 3.6;
            return ((mean + (mean * 16.0)) + bias) + bias2;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) <= (reading + origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
