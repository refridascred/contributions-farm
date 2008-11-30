using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > seen)
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Closed,
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double weight2 = (2.2 + weight) * 16.0;
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + span) - (double)(long)i;
            }
            return weight2 + (double)7;
        }
    }
}
